---
title: Aspose.BarCode for .NET 18.5 Release Notes
type: docs
weight: 120
url: /net/aspose-barcode-for-net-18-5-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for Aspose.BarCode for .NET 18.5.

{{% /alert %}} 

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-36759|Remove obsolete properties from BarCodeReader|Enhancement|
|BARCODENET-36856|GetCustomSizeBarCodeImage method is discarding check digit when generate EAN13 coded barcode|Bug|
|BARCODENET-36869|Fake recognition of MicrE13B barcodes|Bug|

### **Public API and Backward Incompatible Changes**
This section lists public API changes that were introduced in Aspose.BarCode for .NET 18.5. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.BarCode for .NET which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.
## **Obsolete APIs**

|**Type**|**Details**|**Remarks**|
| :- | :- | :- |
|Method|**GetAllPossibleBarCodes** has been removed from classes: <br>Aspose.BarCode.BarCodeRecognition.BarCodeReader|Use **RecognitionMode.MaxBarCodes** and method **GetIsDeniable**|
|Property|**ExpectedBarCodeCount** has been removed from classes:<br>Aspose.BarCode.BarCodeRecognition.BarCodeReader| |
|Property|**OrientationHints** has been removed from classes:<br>Aspose.BarCode.BarCodeRecognition.BarCodeReader|Barcode orientation is detected automatically|
|Enum |Aspose.BarCode.BarCodeRecognition.RecognitionHints has been removed| |
|Class|Aspose.BarCode.BarCodeRecognition.BarCodeReader.PossibleBarCode has been removed| |

