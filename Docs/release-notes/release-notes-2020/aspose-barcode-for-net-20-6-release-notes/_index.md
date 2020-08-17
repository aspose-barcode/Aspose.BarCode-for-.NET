---
title: Aspose.BarCode for .NET 20.6 Release Notes
type: docs
weight: 50
url: /net/aspose-barcode-for-net-20-6-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes information for [Aspose.BarCode for .NET 20.6](https://downloads.aspose.com/barcode/net/new-releases/aspose.barcode-for-.net-20.6/).

{{% /alert %}} 
## **All Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-37514|Add check digit calculation to ITF-6 |Enhancement|
|BARCODENET-37515|Add check digit recognition to ITF-6	Enhancement|
|BARCODENET-37537|Remove obsolete API from BarcodeReader|Enhancement|
|BARCODENET-37474|Investigate addition ECI modes to PDF417 encoder	|Enhancement|
|BARCODENET-37473|Investigate addition of input stream compaction mode PDF417 encoder	|Enhancement|
|BARCODENET-37477|Investigate the addition of new decoding modes to PDF417 processor	|Enhancement|
|BARCODENET-37464|Aspose.Barcode 20.04 Unexpected recognition of barcode on the image without it |Bug|

## **Public API and Backward Incompatible Changes**
- added property Aspose.BarCode.Generation.Pdf417Parameters.Pdf417ECIEncoding
- added field Aspose.BarCode.ECIEncodings.NONE
- removed type Aspose.BarCode.BarCodeRecognition.ICOMBarCodeReader
- removed method Aspose.BarCode.BarCodeRecognition.ICOMBarCodeReader.SetBarCodeImage(System.String)
- removed method Aspose.BarCode.BarCodeRecognition.ICOMBarCodeReader.SetBarCodeReadType(Aspose.BarCode.BarCodeRecognition.BaseDecodeType)
- removed method Aspose.BarCode.BarCodeRecognition.ICOMBarCodeReader.Read
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetCodeType
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetCodeTypeName
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.Close
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.Read
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetCodeText
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetCodeText(System.Text.Encoding)
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetCodeText(System.Boolean)
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetCheckSum
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetAngle
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetRecognitionQuality
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetCodeBytes
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetMacroPdf417FileID
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetMacroPdf417SegmentID
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetMacroPdf417SegmentsCount
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetQRStructuredAppendModeBarCodesQuantity
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetQRStructuredAppendModeBarCodeIndex
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetQRStructuredAppendModeParityData
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetRegion
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetCode128DataPortions
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetDetectEncoding
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.SetDetectEncoding(System.Boolean)
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetIsDeniable
- removed type Aspose.BarCode.BarCodeRecognition.BarCodeRegion
- removed property Aspose.BarCode.BarCodeRecognition.BarCodeRegion.Points
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeRegion.DrawBarCodeEdges(System.Drawing.Graphics,System.Drawing.Pen)
- removed method Aspose.BarCode.BarCodeRecognition.BarCodeRegion.FillBarCodeRegion(System.Drawing.Graphics,System.Drawing.Brush)