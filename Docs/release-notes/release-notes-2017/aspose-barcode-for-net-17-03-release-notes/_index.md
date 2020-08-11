---
title: Aspose.BarCode for .NET 17.03 Release Notes
type: docs
weight: 100
url: /net/aspose-barcode-for-net-17-03-release-notes/
---

Aspose.BarCode for .Net has been updated to version 17.03 and we are pleased to announce it.
The following is a list of changes in this version of Aspose.Imaging.
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-36497|Add [checksum feature for Codabar](/barcode/net/use-checksum-and-supplement-data/#usechecksumandsupplementdata-applyingchecksumvalidationoncodabar)|Feature|
|BARCODENET-36488|[Barcode is not giving correct output](/barcode/net/use-checksum-and-supplement-data/#usechecksumandsupplementdata-getbarcodewithchecksumvalue)|Enhancement|
|BARCODENET-36479|BarCode is not giving correct output when GS1DataMatrix barcode is supplied to read|Enhancement|
|BARCODENET-36475|Unable to recognize barcode of type Code39Standard from a TIFF image|Enhancement|
|BARCODENET-36386|Fake recognition of DutchKIX in MaxBarCodes mode|Enhancement|
|BARCODENET-36487|Generation GS1DataMatrix isn't correct|Enhancement|
# **Usage examples**
**BARCODENET-36497 Add checksum feature for Codabar** 
Code sample:

{{< highlight java >}}

 //Generation

BarCodeBuilder builder = new BarCodeBuilder();

builder.CodeText = "1234567890";

builder.EncodeType = EncodeTypes.Codabar;

builder.EnableChecksum = EnableChecksum.Yes;

builder.CodabarChecksumMode = CodabarChecksumMode.Mod10;

builder.Save("Codabar_Mod10.png");

//Recognition

using (BarCodeReader reader = new BarCodeReader("Codabar_Mod10.png", DecodeType.Codabar))

{

    reader.ChecksumValidation = ChecksumValidation.On;

    while (reader.Read())

    {

        Console.WriteLine("{0}:{1}", reader.GetCodeType(), reader.GetCodeText());

        Console.WriteLine("Checksum:" + reader.GetCheckSum());

    }

}

{{< /highlight >}}

Result:

Codabar:1234567890

Checksum:7

**BARCODENET-36488 Barcode is not giving correct output** 
Code sample:

{{< highlight java >}}

 using (BarCodeReader reader = new BarCodeReader("error5.jpg", DecodeType.EAN13))

{

    while (reader.Read())

    {

        Console.WriteLine("{0}: {1}", reader.GetCodeType(), reader.GetCodeText(true));

    }

}

{{< /highlight >}}

Result:

EAN13: 4902430689342

**BARCODENET-36479 BarCode is not giving correct output when GS1DataMatrix barcode is supplied to read** 
Code sample:

{{< highlight java >}}

 BarCodeBuilder builder = new BarCodeBuilder("(00)123451234512345123", EncodeTypes.GS1DataMatrix);

builder.CodeLocation = CodeLocation.Below;

builder.ImageHeight = 324;

builder.ImageWidth = 244;

builder.Resolution = new Resolution(300, 300, ResolutionMode.Printer);

builder.RotationAngleF = 0;

Bitmap bmp = builder.BarCodeImage;

builder.Dispose();

using (BarCodeReader objBReader = new BarCodeReader(bmp))

{

    while (objBReader.Read())

    {

        Console.WriteLine(objBReader.GetCodeType() + ": " + objBReader.GetCodeText());

    }

}

{{< /highlight >}}

Result:

GS1DataMatrix: (00)123451234512345123

**BARCODENET-36475 Unable to recognize barcode of type Code39Standard from a TIFF image** 
Code sample:

{{< highlight java >}}

 using (BarCodeReader reader = new BarCodeReader("04540001.TIF", DecodeType.Code39Standard))

{

    reader.RecognitionMode = RecognitionMode.MaxBarCodes;

    while (reader.Read())

    {

        Console.WriteLine("{0}: {1}", reader.GetCodeType(), reader.GetCodeText());

    }

}

{{< /highlight >}}

Result:

Code39Standard: 82716A-014595016D

**BARCODENET-36386 Fake recognition of DutchKIX in MaxBarCodes mode**

Code sample:

{{< highlight java >}}

 using (BarCodeReader reader = new BarCodeReader("test1_orig.jpg", DecodeType.DutchKIX))

{

    reader.RecognitionMode = RecognitionMode.MaxBarCodes;

    while (reader.Read())

    {

        Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());

    }

}

{{< /highlight >}}

Result is empty.

**BARCODENET-36487 Generation GS1DataMatrix isn't correct** 
Code sample:

{{< highlight java >}}

 BarCodeBuilder builder = new BarCodeBuilder("(00)123451234512345123", EncodeTypes.GS1DataMatrix);

builder.Save("gs1dataMatrix_(00)123451234512345123.png");

{{< /highlight >}}
