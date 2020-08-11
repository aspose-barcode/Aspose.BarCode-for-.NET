---
title: Aspose.BarCode for .NET 16.10 Release Notes
type: docs
weight: 40
url: /net/aspose-barcode-for-net-16-10-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for Aspose.BarCode for .NET 16.10.

{{% /alert %}} 
### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|BARCODENET-36287 |[Support for GS1-128 AI 8102 Coupon Extended Barcode](http://www.aspose.com/community/forums/thread/761935/question-about-gs1-128-coupon-extended-barcode.aspx)|New Feature|
|BARCODENET-36324 |Support for UPCA & GS1 Databar coupon|New Feature|
|BARCODENET-36332 |[Set Wide Narrow Ratio for barcode symbology : Code128](http://www.aspose.com/community/forums/thread/667946/pixel-shaving-for-linear-barcodes.aspx)|New Feature|
|BARCODENET-33941 |[Can't recognize PDF417 code using the Motorola DS4208 scanner](http://www.aspose.com/community/forums/thread/556415/generated-pdf417-not-recognized.aspx)|Enhancement |
|BARCODENET-36336 |[Barcode generated using Aspose.BarCode after printing is unable to recognized by laser scanner](http://www.aspose.com/community/forums/thread/710416/sometimes-unreadable-code93standard-barcode.aspx)|Enhancement |
|BARCODENET-36321 |[Exclude several unwanted EAN8, MSI, Supplement barcodes](http://www.aspose.com/community/forums/thread/597692.aspx)|Enhancement |
|BARCODENET-36335 |[Generating QR barcode with custom height and width (GraphicsUnit: Inches, Pixel, Millimeter) is not working properly](http://www.aspose.com/community/forums/thread/702984/qr-code-setting-the-size-has-no-effect.aspx)|Enhancement |
|BARCODENET-36247 |[ISSN barcode throws exception for a valid text](http://www.aspose.com/community/forums/thread/727851/issn-value.aspx)|Enhancement |
|BARCODENET-36277 |Improve the irregular grid to recognize more datamtrix|Enhancement |
|BARCODENET-36338 |[Unable to Read the EAN13 barcode from an image](http://www.aspose.com/community/forums/thread/730495/detect-ean13-with-missing-end-marker.aspx)|Enhancement |
|BARCODENET-36326 |License as Embedded resource is not working|Enhancement |
# **Usage examples:**
**BARCODENET-36287 Support for GS1-128 AI 8102 Coupon Extended Barcode** 
Code sample

{{< highlight xml >}}

 BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

barCodeBuilder.SymbologyType = Symbology.UpcaGs1Code128Coupon;

// upca part is "514141100906", GS1Code128 part is "(8102)03"

barCodeBuilder.CodeText = "514141100906(8102)03";

barCodeBuilder.Save("UpcaGs1Code128Coupon.png");

{{< /highlight >}}

**BARCODENET-36324 Support for UPCA & GS1 Databar coupon** 
Code sample

{{< highlight xml >}}

 BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

// upca part is "514141100906", GS1Databar part is "(8110)001234502239811110555"

barCodeBuilder.CodeText = "512345678900(8110)001234502239811110555";

barCodeBuilder.SymbologyType = Symbology.UpcaGs1DatabarCoupon;

barCodeBuilder.CaptionAbove.Text = "012345-022398";

barCodeBuilder.Save("couponUpcaDatabar.png");

{{< /highlight >}}

**BARCODENET-36332 Set Wide Narrow Ratio for barcode symbology** 
Code sample:

{{< highlight xml >}}

 BarCodeBuilder barCodeBuilder = new BarCodeBuilder("blackReduction", Symbology.Code128);

barCodeBuilder.xDimension = 1.2f;

barCodeBuilder.BarWidthReduction = 0.2f;

barCodeBuilder.Save("blackReduction.png");

{{< /highlight >}}

**BARCODENET-33941 Can't recognize PDF417 code using the Motorola DS4208 scanner** 
Code sample:

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder();

builder.SymbologyType = Symbology.Pdf417;

builder.CodeLocation = CodeLocation.None;

builder.EnableEscape = true;

builder.AutoSize = false;

builder.AspectRatio = 4F; // invert 0.25f

builder.Pdf417ErrorLevel = Pdf417ErrorLevel.Level4;

builder.GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter;

builder.ImageHeight = 25.4F; //25.4mm = 1in

builder.ImageWidth = 101.6F; //76.2F; //76.2mm = 3in 101.6mm=4in

builder.xDimension = .6F;

builder.Columns = 7;

builder.CodeText = @"<approximately 600 characters>";

builder.Save(@"pdf417barcode.bmp", BarCodeImageFormat.Bmp);

BarCodeReader reader = new BarCodeReader(@"pdf417barcode.bmp", DecodeType.Pdf417);

while (reader.Read())

{

	Console.WriteLine("CodeText: " + reader.GetCodeText() + " Type: " + reader.GetCodeType());

}

reader.Close();

{{< /highlight >}}

**BARCODENET-36336 Barcode generated using Aspose.BarCode after printing is unable to recognized by laser scanner** 
Code sample:

{{< highlight xml >}}

 BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

barCodeBuilder.CodeText = "15-11-48-02-1386";

barCodeBuilder.SymbologyType = Symbology.Code93Standard;

barCodeBuilder.Save("Code93ChecksumFix.png");

{{< /highlight >}}

**BARCODENET-36321 Exclude several unwanted EAN8, MSI, Supplement barcodes** 
Code sample:

{{< highlight xml >}}

 string[] filenames = {"00000039F.tif", "00000052B.tif"};

int counter = 0;

for (int i = 0; i < filenames.Length; i++)

{

    BarCodeReader reader = new BarCodeReader(filename);

    while (reader.Read())

    {

                    counter++;

                    Console.WriteLine(" Symbol:" + reader.GetCodeType() + " Code :" + reader.GetCodeText());

    }

    reader.Close();

}

{{< /highlight >}}

The results:

{{< highlight xml >}}

 Symbol:DataMatrix Code :DI411416000001

 Symbol:DataMatrix Code :0220000000

 Symbol:DataMatrix Code :DI411416000001

 Symbol:DataMatrix Code :DMapp7of7

 Symbol:DataMatrix Code :DMapp7of7

{{< /highlight >}}

**BARCODENET-36335 Generating QR barcode with custom height and width (GraphicsUnit: Inches, Pixel, Millimeter) is not working properly** 
Code sample:

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder();

builder.SymbologyType = Symbology.QR;

builder.CodeText = ("123456789");

builder.CodeLocation=(CodeLocation.None);

builder.QRErrorLevel=(QRErrorLevel.LevelH);

builder.GraphicsUnit=(GraphicsUnit.Inch);

builder.Margins = new MarginsF(0,0,0,0);

float imageWidth = 2.5f;

float imageHeight = 2.5f;

builder.GetCustomSizeBarCodeImage(imageWidth, imageHeight, false).Save("customSize.png");

{{< /highlight >}}

**BARCODENET-36247 ISSN barcode throws exception for a valid text** 
Code sample:

{{< highlight xml >}}

 BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

barCodeBuilder.CodeText = "0002-8231";

barCodeBuilder.ThrowExceptionWhenCodeTextIncorrect=true;

barCodeBuilder.SymbologyType = Symbology.ISSN;

barCodeBuilder.AutoSize = true;

// Save the image

barCodeBuilder.Save("issn.png");

{{< /highlight >}}

**BARCODENET-36338 Unable to Read the EAN13 barcode from an image** 
Code sample:

{{< highlight xml >}}

 string filename = @"Incorrect2.png";

using (BarCodeReader reader = new BarCodeReader(filename, DecodeType.EAN13))

{

	while (reader.Read())

	{

		Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());

	}

}

{{< /highlight >}}

**BARCODENET-36326 License as Embedded resource is not working** 
Code sample:

{{< highlight xml >}}

 static void Main(string[] args)

{

       Aspose.BarCode.License license = new Aspose.BarCode.License();

       license.SetLicense("SimpleConsole.lic.Aspose.Total.lic");

       //license.SetLicense("SimpleConsole.Aspose.Total.lic");

}

{{< /highlight >}}

Note:
the code below will display the list of available resources (full names)

{{< highlight xml >}}

 string[] resourceNames = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();

{{< /highlight >}}
