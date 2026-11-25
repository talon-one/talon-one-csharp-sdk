# TalonOneSdk.Model.ExportJobDestination

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Destination type can be Google Cloud Storage (gcs) or file. | 
**Compression** | **string** | Compression applied to the exported file. | [optional] [default to CompressionEnum.None]
**Path** | **string** | Directory on the exporter host where the file is written. Required for file destinations; must be omitted for gcs. | [optional] 
**Bucket** | **string** | GCS bucket name for storage. Absent for file. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

