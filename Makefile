BUILD_DIR:=src/TalonOneSdk
VERSION:=$(shell sed -n 's/.*<Version>\(.*\)<\/Version>.*/\1/p' $(PWD)/$(BUILD_DIR)/TalonOneSdk.csproj)

default: testenv

clean:
	rm -rf $(PWD)/$(BUILD_DIR)/TalonOneSdk.$(VERSION)*.nupkg && \
	rm -rf $(PWD)/$(BUILD_DIR)/TalonOneSdk.$(VERSION).snupkg

pack: clean
ifeq ($(VERSION),)
	@echo "***\033[0;31mERROR:\033[0m NO VERSION COULD BE EXTRACTED. Check out the TalonOneSdk.csproj file"
	@exit 1
endif
	docker run \
		--rm \
		-v $(PWD):/tmp/talon-client \
		-w "/tmp/talon-client/$(BUILD_DIR)" \
		mcr.microsoft.com/dotnet/sdk:8.0 \
			dotnet pack TalonOneSdk.csproj \
				-p:PackageVersion=$(VERSION) \
				--output . \
				--configuration Release \
				--include-source

publish: pack
ifeq ($(VERSION),)
	@echo "***\033[0;31mERROR:\033[0m NO VERSION COULD BE EXTRACTED. Check out the TalonOneSdk.csproj file"
	@exit 1
endif
ifeq ($(apiKey),)
	@echo "***\033[0;31mERROR:\033[0m NO apiKey WAS NOT PROVIDED."
	@exit 1
endif
	docker run \
		--rm \
		-v $(PWD):/tmp/talon-client \
		-w "/tmp/talon-client/$(BUILD_DIR)" \
		mcr.microsoft.com/dotnet/sdk:8.0 \
			dotnet nuget push TalonOneSdk.$(VERSION).nupkg \
				--api-key $(apiKey) \
				--source https://api.nuget.org/v3/index.json \
				--skip-duplicate

.PHONY: testenv
testenv:
	docker run \
		--rm -it \
		-v $(PWD):/tmp/talon-client \
		-w /tmp/talon-client \
		mcr.microsoft.com/dotnet/sdk:8.0 \
		/bin/bash

apply-patch:
	@echo "Updating version in TalonOneSdk.csproj"
	@sed -i -E 's|(<Version>)([0-9]+)\.0*([1-9][0-9]*)(</Version>)|\1\2.\3.0\4|' $(PWD)/$(BUILD_DIR)/TalonOneSdk.csproj
	@echo "Applying fix patch"
	@git apply --reject --ignore-space-change --ignore-whitespace ./srcFiles.patch 2>&1; \
	find . -name '*.rej' -delete
