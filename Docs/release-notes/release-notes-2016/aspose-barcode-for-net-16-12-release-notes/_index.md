---
title: Aspose.BarCode for .NET 16.12 Release Notes
type: docs
weight: 20
url: /net/aspose-barcode-for-net-16-12-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for Aspose.BarCode for .NET 16.12.

{{% /alert %}} 
### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|BARCODENET-36410 |[Barcodes generated from VS2010 and VS2012 are different ](https://www.aspose.com/community/forums/thread/732175/aspose-barcode-cannot-be-used-in-vs.aspx)|Enhancement |
|BARCODENET-36365 |Improve recognition speed for Aztec|Enhancement |
|BARCODENET-36383 |Improve recognition speed for Aztec by reducing the number of passes|Enhancement |
|BARCODENET-36380 |Include CodablockF and Coupons in Silverlight control|Enhancement |
|BARCODENET-36387 |Incorrect recognition of CodabloackF with AllSupportedTypes|Enhancement |
|BARCODENET-36398 |[Reading Barcode from a BMP image is generating exception](https://www.aspose.com/community/forums/thread/806966/performance.aspx)|Enhancement |
|BARCODENET-36381 |Remove line offset for CodablockF (GraphicsUnit.Pixel)|Enhancement |
|BARCODENET-36395 |The recognition performance of rotated DataMatrix barcodes has been improved|Enhancement |
|BARCODENET-36419 |Too small quiet zone for ITF14 when border type is Frame or FrameOut|Enhancement |
|BARCODENET-36382 |[Creating a Datamatrix barcode with DataMatrixEccType.Ecc200 throws a null reference exception](http://www.aspose.com/community/forums/thread/804198/creating-a-datamatrix-barcode-with-datamatrixecctype.ecc200-throws-a-null-reference-exception.aspx)|Enhancement |
|BARCODENET-36333 |[Not able to recognize code39standard barcode .NET](http://www.aspose.com/community/forums/thread/676576/not-able-to-extract-barcode.aspx)|Enhancement |
|BARCODENET-36353 |[Barcode reader is unable to recognize the barcode on an image](http://www.aspose.com/community/forums/thread/786272/i-need-to-scan-this-bar-code-returns-wrong-data.aspx)|Enhancement |
|BARCODENET-36406 |[Unable to recognize PDF417 barcode from a drivers' license image](https://www.aspose.com/community/forums/thread/809898/pdf417-not-recognized-in-jpg-image.sometimes.aspx)|Enhancement |
|BARCODENET-36400 |Dynabic.Metered: Aspose.BarCode has to be adjusted to the latest Dynabic.Metered version|Enhancement |
# **Usage examples:**
**BARCODENET-36410 Barcodes generated from VS2010 and VS2012 are different** 
Sample code:

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder();

builder.EncodeType = EncodeTypes.Code128;

builder.CodeText = "7r";

//parameters from SSRS

builder.GraphicsUnit = GraphicsUnit.Inch;

builder.AutoSize = true;

builder.CodeLocation = CodeLocation.None;

builder.xDimension = 0.01f;

builder.yDimension = 0.04f;

builder.BarHeight = 0.22f;

builder.CodeTextSpace = 0f;

builder.Margins = new MarginsF(0.04f, 0.03f, 0.04f, 0.03f);

builder.Resolution.DpiX = 150;

builder.Resolution.DpiY = 150;

builder.Save("barcode_new.png");

{{< /highlight >}}

**BARCODENET-36365 Improve recognition speed for Aztec** 
The recognition speed has been improved for Aztec in MaxQuality mode.
The recognition of 3D-distorted Aztec code has been enhanced by new target detection.

Sample code:

{{< highlight xml >}}

 using (BarCodeReader reader = new BarCodeReader("img2_b_edited.jpg", DecodeType.Aztec))

{

    while (reader.Read())

    {

        Console.WriteLine("{0}: {1}", reader.GetCodeType(), reader.GetCodeText());

    }

}

{{< /highlight >}}

Output:

{{< highlight xml >}}

 Aztec: int main() { AztecCode azt; return 0;} 0123456789 efghijklmnoprstuvwxyz

{{< /highlight >}}

**BARCODENET-36383 Improve recognition speed for Aztec by reducing the number of passes** 
The recognition speed has been improved by means of:

- Skipping very similar targets (centers are close);
- Reducing recognition passes;

Sample:

{{< highlight xml >}}

 Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();

using (BarCodeReader reader = new BarCodeReader("manyRotatedAztecs_2.png", DecodeType.Aztec))

{

    reader.RecognitionMode = RecognitionMode.MaxQuality;

    int number = 0;

    while (reader.Read())

    {

        Console.WriteLine("{0}: {1}: {2}", number, reader.GetCodeType(), reader.GetCodeText());

        number++;

    }

}

stopwatch.Stop();

Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);

{{< /highlight >}}

Results:

{{< highlight xml >}}

 0: Aztec: ABCDEF

1: Aztec: ABCDEF

2: Aztec: AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

3: Aztec: 4565345456545456

4: Aztec: 012345678901234567890123456789

5: Aztec: AaBbCc

6: Aztec: AaBbCc

7: Aztec: AaBbCc

8: Aztec: www.8qr.de/123aq

9: Aztec: AaBbCc

Time elapsed: 00:00:00.7664338

{{< /highlight >}}

**BARCODENET-36387 Incorrect recognition of CodabloackF with AllSupportedTypes**

- Calculation of vertexes for CodablockF has been fixed;
- The postfilter for filtering out the duplicates of Code128 results has been added;

Sample code:

{{< highlight xml >}}

 using (BarCodeReader reader = new BarCodeReader("Codablock-F_Example.png", DecodeType.AllSupportedTypes))

{

    while (reader.Read())

    {

        Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());

    }

}

{{< /highlight >}}

Result:

{{< highlight xml >}}

 CodablockF: Codablock-F Example

{{< /highlight >}}

{{< highlight xml >}}

 using (BarCodeReader reader = new BarCodeReader("codablockfAndCode128_4.png", DecodeType.AllSupportedTypes))

{

    while (reader.Read())

    {

        Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());

    }

}

{{< /highlight >}}

Result:

{{< highlight xml >}}

 Code128: Code128 sample

CodablockF: Codablock F sample

{{< /highlight >}}

**BARCODENET-36398 Reading Barcode from a BMP image is generating exception** 
Code sample

{{< highlight xml >}}

 string filename = @"img_16_notworking.bmp";

BarCodeReader barcodeReader = new BarCodeReader(filename, DecodeType.DataMatrix);

int counter = 0;

while (barcodeReader.Read())

{

   counter++;

   Console.WriteLine(" -- Symbol:" + barcodeReader.GetCodeType() + " Code :" + barcodeReader.GetCodeText());

}

barcodeReader.Close();

{{< /highlight >}}

Result:

{{< highlight xml >}}

 -- Symbol:DataMatrix Code :O60000001670817681446463

{{< /highlight >}}

**BARCODENET-36381 Remove line offset for CodablockF (GraphicsUnit.Pixel)** 
Code sample:

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder("012345601234560123456", EncodeTypes.CodablockF);

builder.GraphicsUnit = GraphicsUnit.Pixel;

builder.Save("CodaBlockF.png");

{{< /highlight >}}

**BARCODENET-36419 Too small quiet zone for ITF14 when border type is Frame or FrameOut** 
Code sample

{{< highlight xml >}}

 using (BarCodeBuilder builder = new BarCodeBuilder())

{

	builder.CodeText = "1234567890";

	builder.EncodeType = EncodeTypes.ITF14;

	builder.ITF14BorderType = ITF14BorderType.FrameOut;

	builder.xDimension = 1f;

	builder.BarCodeImage.Save(@"ITF14_quietZone.png");

}

{{< /highlight >}}

**BARCODENET-36333 Not able to recognize code39standard barcode .NET** 
It is not a bug; Please find the correct code snippet below;

{{< highlight xml >}}

 protected Bitmap PDFToBitmap(string Filename, int Page)

{

    Bitmap lResImage = null;

    try

    {

        //create pdf document from file or from any other source

        Aspose.Pdf.Document lPdfDoc = new Aspose.Pdf.Document(Filename);

        if ((Page < 1) || (lPdfDoc.Pages.Count < Page)) return null;

        //create pdf converter

        Aspose.Pdf.Facades.PdfConverter lPdfConverter = new Aspose.Pdf.Facades.PdfConverter(lPdfDoc);

        //create resolution of the page

        //300 dpi is standard resolution

        lPdfConverter.Resolution = new Aspose.Pdf.Devices.Resolution(300);

        //start and end page set to the required page

        lPdfConverter.StartPage = Page;

        lPdfConverter.EndPage = Page;

        //convert our pdf to image

        lPdfConverter.DoConvert();

        // Create a MemoryStream object to hold the resultant image

        MemoryStream lResStream = new MemoryStream();

        //check if we have the image

        if (lPdfConverter.HasNextImage())

        {

            //save image to stream

            lPdfConverter.GetNextImage(lResStream, System.Drawing.Imaging.ImageFormat.Png);

            lResStream.Position = 0;

            //read the image to Bitmap

            lResImage = new Bitmap(lResStream);

        }

        return lResImage;

    }

    catch(Exception e)

    {

        return null;

    }

}

{{< /highlight >}}

**BARCODENET-36353 Barcode reader is unable to recognize the barcode on an image** 
The issue will not be fixed due to low image quality provided.
It was scanned with low resolution.
In order to have an image recognized well, the scan resolution has to be 300 dpi, at least.

**BARCODENET-36406 Unable to recognize PDF417 barcode from a drivers' license image** 
The issue will not be fixed due to low image quality provided.
In order to have an image recognized well, the scan resolution has to be 300 dpi, at least.
