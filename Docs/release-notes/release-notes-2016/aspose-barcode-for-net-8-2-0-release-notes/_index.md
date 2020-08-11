---
title: Aspose.BarCode for .NET 8.2.0 Release Notes
type: docs
weight: 60
url: /net/aspose-barcode-for-net-8-2-0-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.BarCode for .NET 8.2.0](http://www.aspose.com/downloads/barcode/net/new-releases/aspose.barcode-for-.net-8.2.0/)

{{% /alert %}} 
### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|BARCODENET-36297 |Support to generate Code128C coded barcode |New Feature |
|BARCODENET-34380 |Add Silverlight barcode reader control |New Feature |
|BARCODENET-36276 |Support for setting graphics unit in Compact Framework |New Feature |
|BARCODENET-34378 |Add Silverlight barcode generator control |New Feature |
|BARCODENET-36259 |Add new BarCode type: Aztec Runes |New Feature |
|BARCODENET-36262 |Implement Aztec Runes generator |New Feature |
|BARCODENET-36288 |Add checksum validation for OneCode and AustraliaPost |New Feature |
|BARCODENET-36266 |Implement Aztec Runes decoder |New Feature |
|BARCODENET-36300 |Dynabic.Metered Integration |New Feature |
|BARCODENET-36308 |The empty hexes for MaxiCode (barcode builder) |Enhancement |
|BARCODENET-36278 |Reading Postnet barcode from image is not producing correct results |Enhancement |
|BARCODENET-36310 |Aspose.BarCode is not recognizing correct DataMatix coded barcode |Enhancement |
|BARCODENET-36274 |Support for setting resolution in Compact Framework |Enhancement |
|BARCODENET-36254 |Recognize DataMatrix with the irregular black/white proportions |Enhancement |
|BARCODENET-36312 |Exclude unwanted dutch KIX barcodes |Enhancement |
|BARCODENET-36272 |Generate empty picture with incorrect codetext for Aztec |Enhancement |
|BARCODENET-36292 |Update AustraliaPost generator |Enhancement |
|BARCODENET-34381 |Override platform depending functions |Enhancement |
|BARCODENET-36270 |Improve Aztec encoder speed for long codetext |Enhancement |
|BARCODENET-36303 |Update API for generating CMYK files |Enhancement |
|BARCODENET-34336 |Converting PDF to Image stream and then reading barcode is not working |Enhancement |
|BARCODENET-36263 |Unable to get the supplement code text from EAN13 coded barcode |Enhancement |
|BARCODENET-36283 |DataMatrix barcode can be decoded by using 3rd party online where as Aspose.BarCode is unable to decode |Enhancement |
|BARCODENET-36284 |Incorrect rotated Postnet barcode recognition |Enhancement |
|BARCODENET-36286 |Detects only first Postnet |Enhancement |
# **Usage examples:**
**BARCODENET-36297 - Support to generate Code128C coded barcode** 
Code sample:

The following snippet of code describes how to generate the Code128A, Code128B, Code128C based on the Code Text provided.

{{< highlight xml >}}

 BarCodeBuilder bb = new BarCodeBuilder ("0123456789", Symbology.Code128);

// Save the image

bb.Save (@"Barcode_Issue36297_Code128C.png");

bb = new BarCodeBuilder ("AAA0123456789zzzzz", Symbology.Code128);

// Save the image

bb.Save (@"Barcode_Issue36297_Code128B.png");


bb = new BarCodeBuilder (@"AAA\t\r\n0123456789\t\r\nZZZ", Symbology.Code128);

// Save the image

bb.Save (@"Barcode_Issue36297_Code128A.png");

{{< /highlight >}}

**BARCODENET-36276 - Support for setting graphics unit in Compact Framework** 
Code sample

{{< highlight xml >}}

 Code sample:

{code:xml}

BarCodeBuilder builder = new BarCodeBuilder("12345", Symbology.Code39Standard);

builder.GraphicsUnit = Aspose.BarCode.GraphicsUnit.Millimeter;

builder.xDimension = 0.22f;

builder.BarHeight = 15f;

builder.Resolution = new Resolution(72, 72, ResolutionMode.Customized);

// for .NET 2.0 and upper, to compare results, set margins like default of compact edition

builder.Margins = new MarginsF(8, 6, 4, 2);

System.Drawing.Bitmap barcodeImage = builder.GenerateBarCodeImage();

// compact case: put to pictureBox

pictureBox1.Image = barcodeImage;

// .NET 2.0 and upper: save to file

 barcodeImage.Save("barcode.png", System.Drawing.Imaging.ImageFormat.Png);

{{< /highlight >}}

Result :

{{< highlight xml >}}

 image "barcode.png".

Barcode size:

Compact,  Width = 152 Height = 75

.NET 2.0, Width = 152 Height = 76

{{< /highlight >}}

**BARCODENET-36259 - Add new BarCode type: Aztec Runes** 
Sample generation code:

{{< highlight java >}}

 BarCodeBuilder b = new BarCodeBuilder();

b.CodeText = "25";

b.SymbologyType = Symbology.Aztec;

b.AztecSymbolMode = AztecSymbolMode.Rune;

b.BarCodeImage.Save("testRune25.png");

{{< /highlight >}}

BarCode reader.
Code sample:

{{< highlight java >}}

 using (BarCodeReader reader = new BarCodeReader("spec125.png"))

{

    while (reader.Read())

    {

        Console.WriteLine("{0}", reader.GetCodeType() + ": " + reader.GetCodeText());

    }

}

{{< /highlight >}}

Result:

Aztec: 125

**BARCODENET-36262 - Implement Aztec Runes generator** 
Sample generation code:

{{< highlight java >}}

 BarCodeBuilder b = new BarCodeBuilder();

b.CodeText = "25";

b.SymbologyType = Symbology.Aztec;

b.AztecSymbolMode = AztecSymbolMode.Rune;

b.BarCodeImage.Save("testRune25.png");

{{< /highlight >}}

**BARCODENET-36288 - Add checksum validation for OneCode and AustraliaPost**

Added checksum validation for OneCode and AustraliaPost.
Fixed recognition for rotated AustraliaPost barcodes.
Fixed GetCheckSum() result for OneCode and AustraliaPost.

Sample pictures (australiapost_incorrect.png, onecode2_incorrect.png) are incorrect and can't be recognized in regular mode.
These pictures can be recognized with turn-off checksum validation (ChecksumValidation.Off).

Code sample 1:

{{< highlight java >}}

 using (BarCodeReader r = new BarCodeReader("australiapost_incorrect.png", DecodeType.AustraliaPost))

{

    if (!r.Read())

    {

        Console.WriteLine("Barcode is incorrect!");

    }

}

{{< /highlight >}}

Result:

Barcode is incorrect!

Code sample 2:

{{< highlight java >}}

 using (BarCodeReader r = new BarCodeReader("onecode2_incorrect.png", DecodeType.OneCode))

{

    r.ChecksumValidation = ChecksumValidation.Off;

    while (r.Read())

    {

        Console.WriteLine(r.GetCodeType() + ": " + r.GetCodeText());

        Console.WriteLine("CheckSum: " + r.GetCheckSum());

    }

}

{{< /highlight >}}

Result:

OneCode: 44999000000123456789941078350

CheckSum: 1841

**BARCODENET-36266 - Implement Aztec Runes decoder**

Sample reader code:

{{< highlight java >}}

 using (BarCodeReader reader = new BarCodeReader("aztecRunes25.png"))

{

    while (reader.Read())

    {

        Console.WriteLine("{0}", reader.GetCodeType() + ": " + reader.GetCodeText());

    }

}

{{< /highlight >}}

Result:

Aztec: 25

Second sample reader code:

{{< highlight java >}}

 using (BarCodeReader reader = new BarCodeReader("aztecRunes68.png"))

{

    while (reader.Read())

    {

        Console.WriteLine("{0}", reader.GetCodeType() + ": " + reader.GetCodeText());

    }

}

{{< /highlight >}}

Result:

Aztec: 68

**BARCODENET-36308 - The empty hexes for MaxiCode (barcode builder)** 
Code sample:

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder("111", Symbology.MaxiCode);

builder.GraphicsUnit = GraphicsUnit.Millimeter;

builder.xDimension = 0.22f;

builder.Resolution = new Resolution(72, 72, ResolutionMode.Customized);

Bitmap image1 = builder.GenerateBarCodeImage();

image1.Save("barcode.png", System.Drawing.Imaging.ImageFormat.Png);

{{< /highlight >}}

Result:

{{< highlight xml >}}

 Aspose.BarCode.BarCodeException :

Size of barcode is too small.

Please, increase the xDimension or resolution.

{{< /highlight >}}

Code sample for correct generation:

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder("111", Symbology.MaxiCode);

builder.GraphicsUnit = GraphicsUnit.Millimeter;

builder.xDimension = 3;

Bitmap image1 = builder.GenerateBarCodeImage();

image1.Save("barcode.png", System.Drawing.Imaging.ImageFormat.Png);

{{< /highlight >}}

**BARCODENET-36278 - Reading Postnet barcode from image is not producing correct results**

Code sample:

{{< highlight java >}}

 BarCodeReader objBReader = new BarCodeReader("barcode_ab-1-1.png", DecodeType.Postnet);

int counter = 0;

while (objBReader.Read())

{

    counter++;

    Console.WriteLine(" -- Symbol:" + objBReader.GetCodeType() + " Code: " + objBReader.GetCodeText());

    Console.WriteLine(" -- Angle:" + objBReader.GetAngle());

}

objBReader.Close();

Console.WriteLine(counter.ToString());

{{< /highlight >}}

Result:

` `-- Symbol:Postnet Code: 21842

` `-- Angle:0,6480604

1

Added checksum validation to reject fake results (69840).
Also improved result for GetAngle().
Now returns the same results for different rotation hints:
Sample 1, "Rotate180":

{{< highlight java >}}

 BarCodeReader objBReader = new BarCodeReader(fileName, DecodeType.Postnet);

objBReader.OrientationHints = Aspose.BarCode.BarCodeRecognition.RecognitionHints.Orientation.Rotate180;

int counter = 0;

while (objBReader.Read())

{

    counter++;

    Console.WriteLine(" -- Symbol:" + objBReader.GetCodeType() + " Code: " + objBReader.GetCodeText());

    Console.WriteLine(" -- Angle:" + objBReader.GetAngle());

}

objBReader.Close();

Console.WriteLine(counter.ToString());

{{< /highlight >}}

Result:

` `-- Symbol:Postnet Code: 21842

` `-- Angle:180,6961

1

Sample 2, "Rotate270":

{{< highlight java >}}

 objBReader.OrientationHints = Aspose.BarCode.BarCodeRecognition.RecognitionHints.Orientation.Rotate270;


{{< /highlight >}}

Result:

` `-- Symbol:Postnet Code: 21842

` `-- Angle:270,696

1

Sample 3, "Rotate90":

{{< highlight java >}}

 objBReader.OrientationHints = Aspose.BarCode.BarCodeRecognition.RecognitionHints.Orientation.Rotate90;


{{< /highlight >}}

Result:

` `-- Symbol:Postnet Code: 21842

` `-- Angle:90,64806

1

**BARCODENET-36310 - Aspose.BarCode is not recognizing correct DataMatix coded barcode** 
Fixed the incorrect recognized Datamatrix.
Code sample:

{{< highlight xml >}}

 string filename = @"00000001F.tif";

using (BarCodeReader reader = new BarCodeReader(filename, DecodeType.DataMatrix))

{

	while (reader.Read())

	{

		Console.WriteLine(reader.GetReadType() + ": " + reader.GetCodeText());

	}

}

{{< /highlight >}}

Result:

{{< highlight xml >}}

 DataMatrix: DMapp1of3

DataMatrix: DI011416000001

DataMatrix: 0120000000

DataMatrix: DI011416000001

DataMatrix: DMapp1of3

{{< /highlight >}}

**BARCODENET-36274 - Support for setting resolution in Compact Framework**

Code sample:

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder("12345", Symbology.Code39Standard);

builder.GraphicsUnit = Aspose.BarCode.GraphicsUnit.Millimeter;

builder.xDimension = 0.22f;

builder.BarHeight = 15f;

builder.Resolution = new Resolution(72, 72, ResolutionMode.Customized);

// for .NET 2.0 and upper, to compare results, set margins like default of compact edition

// builder.Margins = new MarginsF(8, 6, 4, 2);

System.Drawing.Bitmap barcodeImage = builder.GenerateBarCodeImage();

// compact case: put to pictureBox

 pictureBox1.Image = barcodeImage;

// .NET 2.0 and upper: save to file

// barcodeImage.Save("barcode.png", System.Drawing.Imaging.ImageFormat.Png);

{{< /highlight >}}

Result :

{{< highlight xml >}}

 image "barcode.png".

Barcode size:

Compact,  Width = 152 Height = 75

.NET 2.0, Width = 152 Height = 76

{{< /highlight >}}

**BARCODENET-36254 - Recognize DataMatrix with the irregular black/white proportions**

Code sample

{{< highlight xml >}}

 string filename = @"irregular-matrix.png";

using (BarCodeReader reader = new BarCodeReader(filename, DecodeType.DataMatrix))

{

	reader.RecognitionMode = RecognitionMode.ManualHints;

	reader.ManualHints = ManualHint.IncorrectBarcodes;

	while (reader.Read())

	{

		Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());

	}

}

{{< /highlight >}}

**BARCODENET-36312 - Exclude unwanted dutch KIX barcodes**

Code sample:

{{< highlight xml >}}

 using (BarCodeReader reader = new BarCodeReader("00000013F.tif", DecodeType.DutchKIX))

{

	int cnt = 0;

	while (reader.Read())

	{

		cnt++;

		Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());

	}

	Console.WriteLine(String.Format("Read {0} barcodes", cnt));

}

{{< /highlight >}}

Result:

{{< highlight xml >}}

 Read 0 barcodes

{{< /highlight >}}

**BARCODENET-36272 - Generate empty picture with incorrect codetext for Aztec**

Sample 1.
With correct codetext with 3067 characters:

{{< highlight xml >}}

 BarCodeBuilder b = new BarCodeBuilder();

b.CodeText = new string('A', 3067);

b.SymbologyType = Symbology.Aztec;

b.BarCodeImage.Save("maximumText.png");

{{< /highlight >}}

Sample 2.
With incorrect codetext (over limit) - 3068 characters:

{{< highlight java >}}

 BarCodeBuilder b = new BarCodeBuilder();

b.CodeText = new string('A', 3068);

b.SymbologyType = Symbology.Aztec;

b.BarCodeImage.Save("maximumText.png");

{{< /highlight >}}

Result:

{{< highlight xml >}}

 throws InvalidCodeException.

{{< /highlight >}}

**BARCODENET-36292 - Update AustraliaPost generator** 
Added support new encodings for Customer Infomation Field in AustraliaPost builder.
New propery CustomerInformationInterpretingType was added to BarCodeBuilder class.

Code sample for generating Standard Customer Barcode:

{{< highlight java >}}

 BarCodeBuilder b = new BarCodeBuilder();

b.CodeText = "1112345678";

b.SymbologyType = Symbology.AustraliaPost;

b.BarCodeImage.Save("australiapost_new.png");

{{< /highlight >}}

Code sample for generating and recognizing barcode in Customer Barcode 2 format with N Encoding Table:

{{< highlight java >}}

 BarCodeBuilder b = new BarCodeBuilder();

b.CodeText = "5912345678123456";

b.SymbologyType = Symbology.AustraliaPost;

b.CustomerInformationInterpretingType = CustomerInformationInterpretingType.NTable;

b.BarCodeImage.Save("australiapost_NTable.png");

using (BarCodeReader r = new BarCodeReader("australiapost_CTable.png", DecodeType.AustraliaPost))

{

    r.CustomerInformationInterpretingType = CustomerInformationInterpretingType.NTable;

    while (r.Read())

    {

        Console.WriteLine(r.GetCodeType() + ": " + r.GetCodeText());

    }

}

{{< /highlight >}}

Result:

AustraliaPost: 5912345678123456

Code sample for generating and recognizing barcode in Customer Barcode 3 format with C Encoding Table:

{{< highlight java >}}

 BarCodeBuilder b = new BarCodeBuilder();

b.CodeText = "6212345678ABCdef123#";

b.SymbologyType = Symbology.AustraliaPost;

b.CustomerInformationInterpretingType = CustomerInformationInterpretingType.CTable;

b.BarCodeImage.Save("australiapost_CTable.png");

using (BarCodeReader r = new BarCodeReader("australiapost_CTable.png", DecodeType.AustraliaPost))

{

    r.CustomerInformationInterpretingType = CustomerInformationInterpretingType.CTable;

    while (r.Read())

    {

        Console.WriteLine(r.GetCodeType() + ": " + r.GetCodeText());

    }

}

{{< /highlight >}}

Result:

AustraliaPost: 6212345678ABCdef123#

Code sample for generating barcode in Customer Barcode 2 format with raw data ('0', '1', '2' or '3' symbol in Customer Information Field):

{{< highlight java >}}

 BarCodeBuilder b = new BarCodeBuilder();

b.CodeText = "59123456780123012301230123";

b.SymbologyType = Symbology.AustraliaPost;

b.CustomerInformationInterpretingType = CustomerInformationInterpretingType.Other;

b.BarCodeImage.Save("australiapost_Other.png");

using (BarCodeReader r = new BarCodeReader("australiapost_CTable.png", DecodeType.AustraliaPost))

{

    r.CustomerInformationInterpretingType = CustomerInformationInterpretingType.Other;

    while (r.Read())

    {

        Console.WriteLine(r.GetCodeType() + ": " + r.GetCodeText());

    }

}

{{< /highlight >}}

Result:

AustraliaPost: 59123456780123012301230123

**BARCODENET-36303 - Update API for generating CMYK files**

New public value TiffInCmyk has been added to the BarCodeImageFormat for saving CMYK pictures in standard Save method.

Code sample:

{{< highlight java >}}

 BarCodeBuilder barcode = new BarCodeBuilder("1234567890", Symbology.Code39Standard);

barcode.Save("code39Standard_in_cmyk.tiff", BarCodeImageFormat.TiffInCmyk);

{{< /highlight >}}

Code sample with parameters:

{{< highlight java >}}

 BarCodeBuilder barcode = new BarCodeBuilder("1234567890", Symbology.QR);

barcode.Resolution.DpiX = 200;

barcode.ForeColor = Color.Blue;

barcode.CodeTextColor = Color.Red;

barcode.BackColor = Color.LightPink;

barcode.Save("qr_in_cmyk.tiff", BarCodeImageFormat.TiffInCmyk);

{{< /highlight >}}

New public value Emf has been added to the BarCodeImageFormat for saving Enhanced Metafile (EMF) pictures in standard Save method.

Code sample:

{{< highlight java >}}

 BarCodeBuilder barcode = new BarCodeBuilder("1234567890", Symbology.Code39Standard);

barcode.Save("code39Standard.emf", BarCodeImageFormat.Emf);

{{< /highlight >}}

**BARCODENET-34336 - Converting PDF to Image stream and then reading barcode is not working .Net** 
Code sample

{{< highlight xml >}}

 try

{

	// set the license for Aspose.BarCode for .NET and Aspose.Pdf for .NET components

	Aspose.BarCode.License licenceBarCode = new Aspose.BarCode.License();

	licenceBarCode.SetLicense(@"C:\Aspose.Total.lic");

	Aspose.Pdf.License licensePdf = new Aspose.Pdf.License();

	licensePdf.SetLicense(@"C:\Aspose.Total.lic");

	// bind the pdf document

	Aspose.Pdf.Facades.PdfExtractor pdfExtractor = new Aspose.Pdf.Facades.PdfExtractor();

	pdfExtractor.BindPdf(@"C:\Input\SamplePdf.pdf");

	// set page range for image extraction

	pdfExtractor.StartPage = 1;

	pdfExtractor.EndPage = 5;

	// extract the images

	Console.WriteLine("Extracting images.....");

	pdfExtractor.ExtractImage();

	// save images to stream in a loop

	while (pdfExtractor.HasNextImage())

	{

		Console.WriteLine("Getting next image....");

		// save image to stream

		MemoryStream imageStream = new MemoryStream();

		pdfExtractor.GetNextImage(imageStream);

		imageStream.Position = 0;

		Console.WriteLine("Recognizing barcode....");

		// recognize the barcode from the image stream above

		Aspose.BarCodeRecognition.BarCodeReader barcodeReader =

			new Aspose.BarCodeRecognition.BarCodeReader(imageStream);

		while (barcodeReader.Read())

		{

			Console.WriteLine("Codetext found: " + barcodeReader.GetCodeText() + ", Symbology: " + barcodeReader.GetReadType().ToString());

		}

		// close the reader

		barcodeReader.Close();

	}

}

catch (Exception ex)

{

	Console.WriteLine(ex.Message);

}

{{< /highlight >}}

**BARCODENET-36263 - Unable to get the supplement code text from EAN13 coded barcode**

Code sample

{{< highlight xml >}}

 string filename = @"PB_2016_06.jpg";

BarCodeReader reader = new BarCodeReader(filename, DecodeType.EAN13, DecodeType.Supplement);

reader.RecognitionMode = Aspose.BarCode.BarCodeRecognition.RecognitionMode.MaxQuality;

reader.ChecksumValidation = Aspose.BarCode.BarCodeRecognition.ChecksumValidation.Default;

while (reader.Read())

{

	string codeText = reader.GetCodeText();

	string codeType = reader.GetCodeType().ToString();

	string codeChecksum = reader.GetCheckSum();

	Console.WriteLine(codeType + ":" + codeText + "," + codeChecksum);

}

reader.Close();

{{< /highlight >}}

Result:

{{< highlight xml >}}

 EAN13:977156251000,9

Supplement:00616,

{{< /highlight >}}

**BARCODENET-36283 - DataMatrix barcode can be decoded by using 3rd party online where as Aspose.BarCode is unable to decode**

Code sample

{{< highlight xml >}}

 string filename = @"2bea0d7c-2a1b-445a-90cf-15b61b53f7a1.bmp";

using (BarCodeReader reader = new BarCodeReader(filename, DecodeType.DataMatrix))

{

	while (reader.Read())

	{

		Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());

	}

}

{{< /highlight >}}

Result:

{{< highlight xml >}}

 DataMatrix: AK46135U11098U118VC12080D

{{< /highlight >}}

**BARCODENET-36284 - Incorrect rotated Postnet barcode recognition**

Code sample:

{{< highlight java >}}

 BarCodeReader objBReader = new BarCodeReader("postnet2_rot180.png", DecodeType.Postnet);

int counter = 0;

while (objBReader.Read())

{

    counter++;

    Console.WriteLine(" -- Symbol:" + objBReader.GetCodeType() + " Code: " + objBReader.GetCodeText());

    Console.WriteLine(" -- Angle:" + objBReader.GetAngle());

}

objBReader.Close();

Console.WriteLine(counter.ToString());

{{< /highlight >}}

Result:

` `-- Symbol:Postnet Code: 56789

` `-- Angle:180

1

**BARCODENET-36286 - Detects only first Postnet**

Code sample:

{{< highlight java >}}

 BarCodeReader objBReader = new BarCodeReader("postnet_two.png", DecodeType.Postnet);

int counter = 0;

while (objBReader.Read())

{

    counter++;

    Console.WriteLine(" -- Symbol:" + objBReader.GetCodeType() + " Code: " + objBReader.GetCodeText());

    Console.WriteLine(" -- Angle:" + objBReader.GetAngle());

}

objBReader.Close();

Console.WriteLine(counter.ToString());

{{< /highlight >}}

Result:

` `-- Symbol:Postnet Code: 12345

` `-- Angle:0

` `-- Symbol:Postnet Code: 23456

` `-- Angle:90

2

**BARCODENET-36300 - Dynabic.Metered Integration** 
New class Metered has been added in order to provide the set of methods to apply metered key.
In this example, an attempt will be made to set metered public and private key

{{< highlight xml >}}

 Metered matered = new Metered();

matered.SetMeteredKey("PublicKey", "PrivateKey");

{{< /highlight >}}
