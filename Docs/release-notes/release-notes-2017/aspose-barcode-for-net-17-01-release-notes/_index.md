---
title: Aspose.BarCode for .NET 17.01 Release Notes
type: docs
weight: 120
url: /net/aspose-barcode-for-net-17-01-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for Aspose.BarCode for .NET 17.01

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-36423|Reading problem of DataMatrix barcode|Enhancement|
|BARCODENET-36405|[Creating barcode of 300 dpi is producing wider barcode image](https://www.aspose.com/community/forums/thread/808431/barcode-resolution-size.aspx)|Enhancement|
|BARCODENET-36404|[Barcode generated with WPF application is not showing code text at the center of the image](https://www.aspose.com/community/forums/thread/808431/barcode-resolution-size.aspx)|Enhancement|
|BARCODENET-36403|[Barcode generated with WinForms application and WPF is different](https://www.aspose.com/community/forums/thread/808431/barcode-resolution-size.aspx)|Enhancement|
|BARCODENET-36352|Implement algorithm for recognizing 3D-distorted MicroQr|Enhancement|
|BARCODENET-34234|[BarCodeBuilder does not generate CodeText for characters: "~B" and "~C" properly for PDF417;](http://www.aspose.com/community/forums/thread/644330/pdf417-barcode-not-encoding-tilde.aspx)|Enhancement|
|BARCODENET-33257|[Cannot recognize DataMatrix when image has been scanned at 200DPI](http://www.aspose.com/community/forums/thread/376559/cannot-read-barcode-when-aspose.words-document-is-saved-as-pdf.aspx)|Enhancement|
# **Usage examples:**
**BARCODENET-36403 Barcode generated with WinForms application and WPF is different**

Sample:

{{< highlight java >}}

 using (BarCodeBuilder builder = new BarCodeBuilder())

{

      builder.GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter;

      //Set the Code text for the barcode

      builder.CodeText = "6040223579";

      //default resolution

      builder.Resolution = new Aspose.BarCode.Resolution(96, 96, ResolutionMode.Graphics);

      //Set the symbology type to Code128

      builder.EncodeType = Aspose.BarCode.Generation.EncodeTypes.Code128;

      //Set the rotation angle of the barcode

      builder.RotationAngleF = 0;

      builder.BarHeight = 4;

      builder.yDimension = 4;

      builder.CodeTextAlignment = System.Drawing.StringAlignment.Center;

      builder.CodeLocation = CodeLocation.Below;

      builder.CaptionAbove = null;

      builder.SupplementSpace = 0;

      builder.CodeTextSpace = 0;

      //Save image to view result

      builder.BarCodeImage.Save(@"test_barcode_winfroms.tif", System.Drawing.Imaging.ImageFormat.tif);

}

{{< /highlight >}}

Result: test_barcode_winfroms.Tifff

Note: to reduce space below codetext, please add to the code

{{< highlight java >}}

 builder.Margins.Bottom = 0;

because default value is 1

{{< /highlight >}}

**BARCODENET-36352 Implement algorithm for recognizing 3D-distorted MicroQr**

Sample:

{{< highlight java >}}

 using (BarCodeReader reader = new BarCodeReader("SonyDV_BatteryPack_00.JPG", DecodeType.MicroQR))

{

    reader.RecognitionMode = RecognitionMode.MaxQuality;

    while (reader.Read())

    {

        Console.WriteLine(reader.GetCodeText());

    }

}

{{< /highlight >}}

Result:

{{< highlight java >}}

 FV50CE

{{< /highlight >}}

**BARCODENET-34234 BarCodeBuilder does not generate CodeText for characters: "~B" and "~C" properly for PDF417;**

Sample:

{{< highlight java >}}

 using (BarCodeBuilder builder = new BarCodeBuilder()

{

    EncodeType = EncodeTypes.Pdf417,

    Pdf417ErrorLevel = Pdf417ErrorLevel.Level4,

    CodeLocation = CodeLocation.None,

    Columns = 8

})

{

    builder.CodeText = "A^aa^a^a^a^someFreeText~B^bb^b^b^b^OtherFreeText~C^cc^c^c^c^LastFreeText|";

    using (MemoryStream stream = new MemoryStream())

    {

        builder.Save(stream, BarCodeImageFormat.Jpeg);

        stream.Seek(0, SeekOrigin.Begin);


        BarCodeReader reader = new BarCodeReader(stream, DecodeType.Pdf417);

        while (reader.Read())

        {

            Console.WriteLine(reader.GetCodeText());

        }

    }

}

{{< /highlight >}}

Result:

{{< highlight java >}}

 A^aa^a^a^a^someFreeText~B^bb^b^b^b^OtherFreeText~C^cc^c^c^c^LastFreeText|

{{< /highlight >}}

Note: To input decimal ascii code try next sample.
Sample:

{{< highlight java >}}

 using (BarCodeBuilder builder = new BarCodeBuilder(@"ABC\010ABC", EncodeTypes.Pdf417))

{

    builder.EnableEscape = true;

    using (MemoryStream stream = new MemoryStream())

    {

        builder.Save(stream, BarCodeImageFormat.Jpeg);


        BarCodeReader reader = new BarCodeReader(stream, DecodeType.Pdf417);

        while (reader.Read())

        {

            Console.WriteLine(reader.GetCodeText());

        }

    }

}

{{< /highlight >}}

Result:

{{< highlight java >}}

 ABC

ABC

{{< /highlight >}}

**BARCODENET-33257 Cannot recognize DataMatrix when image has been scanned at 200DPI**

Sample:

{{< highlight java >}}

 string[] files = new[]

{

    @"Barcode200DPIA.png",

    @"Barcode200DPIB.png",

    @"Barcode200DPIC.png",

};

foreach (var filename in files)

{

    using (BarCodeReader reader = new BarCodeReader(filename, DecodeType.DataMatrix))

    {

        reader.RecognitionMode = RecognitionMode.MaxBarCodes;

        while (reader.Read())

        {

            Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());

        }

    }

}

{{< /highlight >}}

Result:

{{< highlight java >}}

 DataMatrix: ZZZ#WAS#EF#0203##Unknown#Cost Estimate - Conventional#Cost Estimate Sheet#Test#6/19/2012#True#N/A

DataMatrix: ZZZ#WAS#EF#0203##Unknown#Summary MSS#Summary MSS#Test#6/19/2012#True#N/A

DataMatrix: ZZZ#WAS#EF#0203##Unknown#VA Purchase Agreement#Purchase Agreement#Test#6/19/2012#True#N/A

{{< /highlight >}}
