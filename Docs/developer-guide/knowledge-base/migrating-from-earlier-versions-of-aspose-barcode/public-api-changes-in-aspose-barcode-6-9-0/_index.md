---
title: Public API Changes in Aspose.BarCode 6.9.0
type: docs
weight: 40
url: /net/public-api-changes-in-aspose-barcode-6-9-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.BarCode API from version 6.7.0 to 6.9.0, that may be of interest to module/application developers. It includes not only new and updated public methods, but also a description of any changes in the behavior behind the scenes in Aspose.BarCode. 

{{% /alert %}} 
### **Property Symbology.MicroPdf417 is added**
We’ve added encoding support of Micro Pdf417 symbology, whereas decoding capability is already present.

{{< highlight java >}}

 BarCodeBuilder builder = new BarCodeBuilder("12345", Symbology.MicroPdf417);

builder.Save("PatchCode.png");

{{< /highlight >}}
### **Property BarCodeReadType.MicroQR is added**
We’ve added decoding support of Micro QR symbology.

{{< highlight java >}}

 BarCodeReader reader = new BarCodeReader(fileName, BarCodeReadType.MicroQR);

reader.Read();

string res = reader.GetCodeText();

reader.Close();

{{< /highlight >}}
### **Added Support of Various Recognition Modes**
Added new APIs:
Class Aspose.BarCodeRecognition.RecognitionMode
Field/Enum Aspose.BarCodeRecognition.RecognitionMode.MaxPerformance
Field/Enum Aspose.BarCodeRecognition.RecognitionMode.MaxQuality
Field/Enum Aspose.BarCodeRecognition.RecognitionMode.MaxBarCodes
Field/Enum Aspose.BarCodeRecognition.RecognitionMode.ManualHints

Class Aspose.BarCodeRecognition.ManualHint
Field/Enum Aspose.BarCodeRecognition.ManualHint.None
Field/Enum Aspose.BarCodeRecognition.ManualHint.InvertImage
Field/Enum Aspose.BarCodeRecognition.ManualHint.IncorrectBarcodes
Field/Enum Aspose.BarCodeRecognition.ManualHint.ComplexBackground

It allows clients to configure options of recognition accuracy and speed manually. For more information, please visit [Switch Barcode Recognition Modes According to the Requirement](/pages/createpage.action?spaceKey=barcodenet&title=Switch+Barcode+Recognition+Modes+According+to+the+Requirement&linkCreation=true&fromPageId=12943441).
### **Property BarCodeBuilder.FilledBars is added**
It allows to generate filled or not filled bars. This property works only with 1D barcodes. Default value is true (filled).
The following is an example of the new API usage:

{{< highlight java >}}

 using (BarCodeBuilder builder = new BarCodeBuilder("TEXT", Symbology.Code128))

{

    builder.FilledBars = false;

    builder.Save(fileName);

}

{{< /highlight >}}
### **Added Support of Detecting Unicode Text**
Added new APIs:
Method Aspose.BarCodeRecognition.BarCodeReader.GetDetectEncoding()
Method Aspose.BarCodeRecognition.BarCodeReader.SetDetectEncoding(System.Boolean)

Following help topic shows, how clients can detect unicode characters: [Detect the Unicode Encoding of the Barcode](/pages/createpage.action?spaceKey=barcodenet&title=Detect+the+Unicode+Encoding+of+the+Barcode&linkCreation=true&fromPageId=12943441).
