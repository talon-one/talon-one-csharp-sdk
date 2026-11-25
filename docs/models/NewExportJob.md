# TalonOneSdk.Model.NewExportJob

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **ExportJobType** |  | 
**Args** | **Dictionary&lt;string, Object&gt;** | Arguments for the exporter. Their structure depends on &#x60;type&#x60; and is validated by the service. | 
**Destination** | [**List&lt;ExportJobDestination&gt;**](ExportJobDestination.md) | Destinations for the export job. | 
**CronSchedule** | **string** | Schedule in standard 5-field cron format. | 
**Timezone** | **string** | A string containing an IANA timezone descriptor. | [optional] [default to "UTC"]
**Enabled** | **bool** | Whether the export job is enabled. | [optional] [default to false]
**AllowConcurrentRuns** | **bool** | Whether to allow concurrent runs of the job. | [optional] [default to false]
**OverrideFilename** | **string** | Filename that replaces the generated export filename, without extension. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

