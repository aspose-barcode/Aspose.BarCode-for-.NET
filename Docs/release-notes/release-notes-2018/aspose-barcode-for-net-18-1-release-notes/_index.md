---
title: Aspose.BarCode for .NET 18.1 Release Notes
type: docs
weight: 160
url: /net/aspose-barcode-for-net-18-1-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for Aspose.BarCode for .NET 18.1

{{% /alert %}} 

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-36647|Add support to save barcode in SVG|Feature|
|BARCODENET-34191|Add support to save barcode in any Vector image format|Feature|
|BARCODENET-36783|Support to generate and recognize EPC QR coded barcode|Feature|
|BARCODENET-36753|Improved drawing text when font is specified|Enhancement|
|BARCODENET-36755|Mark BarCodeReader API as obsolete|Enhancement|
|BARCODENET-36760|Barcode is rendered without text|Bug|
|BARCODENET-36750|Incorrectly saving a picture to a file|Bug|
|BARCODENET-36738|Property CodeLocation works incorrectly|Bug|
### **Public API and Backward Incompatible Changes**
This section lists public API changes that were introduced in Aspose.BarCode for .NET 18.1. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.BarCode for .NET which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.
## **Added APIs**

|**Type**|**Details**|**Remarks**|
| :- | :- | :- |
|` `Field/Enum|New public value **Svg** has been added to **BarCodeImageFormat** emun. It allows to save barcode in **Scalable Vector Graphics (SVG)** format. |Evaluation version of Aspose.BarCode allows Code39 barcodes symbology to be saved into SVG format.|
**Code sample**:



{{< highlight java >}}

 string codeText = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ";

using (BarCodeBuilder builder = new BarCodeBuilder(codeText, EncodeTypes.Code128))

{

    builder.Save("code128.svg", BarCodeImageFormat.Svg);

}

{{< /highlight >}}
## **Obsolete APIs**
Following APIs are marked as obsolete. Do not use them anymore. Barcode orientation is detected automatically.

|**Type**|**Details**|
| :- | :- |
|Class|Aspose.BarCode.BarCodeRecognition.RecognitionHints|
|enum|Aspose.BarCode.BarCodeRecognition.RecognitionHints.Orientation|
|property|Aspose.BarCode.BarCodeRecognition.BarCodeReader.OrientationHints|
|Property|Aspose.BarCode.BarCodeRecognition.BarCodeReader.ExpectedBarCodeCount<br>(Do not use it anymore. **ExpectedBarCodeCount** does not have any influence on recognition speed)|
|Method|Aspose.BarCode.BarCodeRecognition.BarCodeReader.GetAllPossibleBarCodes<br>(Use property **BarCodeReader.RecognitionMode = RecognitionMode.MaxBarCodes** and check method **BarCodeReader.GetIsDeniable()** while reading barcode.|



