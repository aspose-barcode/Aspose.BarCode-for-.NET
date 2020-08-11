---
title: Aspose.BarCode for .NET 18.11 Release Notes
type: docs
weight: 40
url: /net/aspose-barcode-for-net-18-11-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for Aspose.BarCode for .NET 18.11.

{{% /alert %}} 
## **New Features**
- Add new barcode subsets to DecodeType
- Not able to detect the barcode
- Improve the recognition of a 3D-distorted and rotated 2D-barcodes
- Improve the recognition of a 3D-distorted QR code 
- Add minor fixes to BarCodeReader
- Improve WPF control appearance 
- GS1 DataBar Expanded Stacked barcode did not pass GS1 Canda barcode verification
## **All Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-37019|Add new Barcode subsets to DecodeType |New Feature|
|BARCODENET-36945|Not able to detect Barcode|New Feature|
|BARCODENET-34367|Improve the recognition of a 3D-distorted and rotated 2D-barcodes|New Feature|
|BARCODENET-36389|Improve the recognition of a 3D-distorted QR code|New Feature|
|BARCODENET-37020|Add minor fixes to BarCodeReader|New Feature|
|BARCODENET-36648|Improve WPF control appearance|New Feature|
|BARCODENET-37026|GS1 DataBar Expanded Stacked barcode did not pass GS1 Canda barcode verification|New Feature|
|BARCODENET-37010|Barcode CODE39 reading problem|Bug|
|BARCODENET-37000|Barcode Detection does not constrain to the defined region.|Bug|
|BARCODENET-37028|Add fix to MicrE13B for safe bitmap access|Bug|
## **Public API and Backward Incompatible Changes**
Following members have been added:
Field DecodeType.Types1D
Field DecodeType.PostalTypes
Field DecodeType.MostCommonTypes
Method BarCodeBuilder.DrawWpf
Method WPF.BarCodeElement.OnRenderSizeChanged

Obsolete hints were added to ManualHint and RecognitionMode enums.
