# Migration guide

This document provides guidance on how to migrate from the [legacy version](https://github.com/talon-one/TalonOne.cs)
of the SDK to the latest version. Follow the steps below to ensure a smooth transition.

## Summary

The new C# SDK has some structural changes so it fits the current best practices. This
means the constructors are updated and the methods responsible for HTTP requests are
changed to be asynchronous.

## Steps

Follow these steps to migrate your code from the legacy C# SDK to the new version:

1. Install the new package, which has been renamed from `TalonOne` to `TalonOneSdk` ([Nuget](https://www.nuget.org/packages/TalonOneSdk/)):

   ```diff
   -  dotnet add package TalonOne
   +  dotnet add package TalonOneSdk
   ```

2. Update the namespaces accordingly:
   
   ```diff
   -  using TalonOne.Api;
   -  using TalonOne.Client;
   -  using TalonOne.Model;
   +  using TalonOneSdk.Api;
   +  using TalonOneSdk.Client;
   +  using TalonOneSdk.Model;
   ```

3. Check your code for issues, primarily related to service initialization and
   asynchronous methods. Resolve these issues manually. For more information, refer to the
   example file.
