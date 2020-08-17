---
title: Aspose.BarCode for .NET 20.4 Release Notes
type: docs
weight: 60
url: /net/aspose-barcode-for-net-20-4-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for [Aspose.BarCode for .NET 20.4](https://downloads.aspose.com/barcode/net/new-releases/aspose.barcode-for-.net-20.4/).

{{% /alert %}} 
## **All Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-37197|Option to set Barcode value while creating barcode of type PatchCode |Enhancement|
|BARCODENET-37413|Investigate improvements to MBase 1D processor to improve recognition quality|Bug|
|BARCODENET-37417|Aspose.Barcode 20.01 Unexpected recognition on QR-Code with no image borders as DataLogic2of5 |Bug|
|BARCODENET-37422|Unable to read barcodes from TIFF|Bug|
|BARCODENET-37425|Unable to read specific barcodes |Bug|
|BARCODENET-37435|Arabic text raises System.NullReferenceException |Bug|
|BARCODENET-37437|NullReferenceException in Barcode generation in Full Debug mode VS2019 |Bug|
## **Public API and Backward Incompatible Changes**
- added property Aspose.BarCode.Generation.BarcodeParameters.PatchCode
- added class Aspose.BarCode.Generation.PatchCodeParameters
- added property Aspose.BarCode.Generation.PatchCodeParameters.ExtraBarcodeText
- added property Aspose.BarCode.Generation.PatchCodeParameters.PatchFormat
- added method Aspose.BarCode.Generation.PatchCodeParameters.ToString
- added type Aspose.BarCode.Generation.PatchFormat
- added field Aspose.BarCode.Generation.PatchFormat.PatchOnly
- added field Aspose.BarCode.Generation.PatchFormat.A4
- added field Aspose.BarCode.Generation.PatchFormat.A4_LANDSCAPE
- added field Aspose.BarCode.Generation.PatchFormat.US_Letter
- added field Aspose.BarCode.Generation.PatchFormat.US_Letter_LANDSCAPE
- added method Aspose.BarCode.Metered.GetConsumptionCredit
