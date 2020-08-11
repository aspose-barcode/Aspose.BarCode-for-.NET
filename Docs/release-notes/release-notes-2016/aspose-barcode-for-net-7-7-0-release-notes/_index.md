---
title: Aspose.BarCode for .NET 7.7.0 Release Notes
type: docs
weight: 110
url: /net/aspose-barcode-for-net-7-7-0-release-notes/
---

The list of improvements and changes that are released in Aspose.BarCode .NET as follows:
## **New Features**
BARCODENET-3426 Add MaxiCode implementation
## **Enhancements**
BARCODENET-34359 Can't recognize Aztec code

BARCODENET-34359 Can't recognize Aztec code

BARCODENET-34352 Recognize 1d barcodes with a heterogeneous brightness

BARCODENET-34352 Recognize 1d barcodes with a heterogeneous brightness

BARCODENET-34324 Unable to read barcode from image containing graphic in it, unless the graphic is removed from the file

BARCODENET-34223 Incorrect code and type returned by Aspose.BarCode for Intelligent Mail barcodes

BARCODENET-34196 Incorrect recognition of the Code128 from the tif image

BARCODENET-34064 Can't recognize QR code from the PDF document

BARCODENET-33968 Barcode recognition is returning more bytes

BARCODENET-33859 Can't recognize unknown codes from tif image

BARCODENET-33636 Unable to recognize Pdf417 barcode after correct perspective problem

BARCODENET-33636 Unable to recognize Pdf417 barcode after correct perspective problem

BARCODENET-18901 EAN and PZN barcodes are not recognized correctly

BARCODENET-18901 EAN and PZN barcodes are not recognized correctly

BARCODENET-15724 cannot recognize code39 barcode

Usage examples:

BARCODENET-3426 Add MaxiCode implementation

{{< highlight java >}}

 Code sample


Code sample

BarCodeBuilder builder = new BarCodeBuilder("MaxiCode (19 chars)", Symbology.MaxiCode);


BarCodeBuilder builder = new BarCodeBuilder("MaxiCode (19 chars)", Symbology.MaxiCode);



builder.Save("MaxiCode.png", BarCodeImageFormat.Png);


builder.Save("MaxiCode.png", BarCodeImageFormat.Png);

{{< /highlight >}}

BARCODENET-34359 Can't recognize Aztec code

Code sample

{{< highlight java >}}



string codeText =

"#:IwQAANtYAAJDAP8xAHwAQgBBAPtLADAAORr"

;

BarCodeBuilder builder = new BarCodeBuilder (codeText, Symbology.Aztec);

using ( BarCodeReader reader = new BarCodeReader (builder.GenerateBarCodeImage ()) )

{

reader.RecognitionMode = RecognitionMode.MaxQuality;

bool success = false;

while ( success = reader.Read () )

{

BarCodeReadType tp = reader.GetReadType ();

string txt = reader.GetCodeText ();

Console.WriteLine (

"Type:{0}, Text:{1}"

, tp, txt);

}

}

Console.WriteLine (

"Press any key to continue..."

);

Console.ReadKey ();


Result:

Type:Aztec, Text:#:IwQAANtYAAJDAP8xAHwAQgBBAPtLADAAORr

{{< /highlight >}}

BARCODENET-34324 Unable to read barcode from image containing graphic in it, unless the graphic is removed from the file

Code sample

{{< highlight java >}}



using (BarCodeReader reader = new BarCodeReader(

"Test3.png"

, BarCodeReadType.Code128))

{

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}


Result:

Code128: SCN000184622

{{< /highlight >}}

BARCODENET-34196 Incorrect recognitions of the Code128 from the tif image

Code sample

{{< highlight java >}}



string filename = @

"8651_002_Invoice_Front.tif"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.Code128))

{

reader.RecognitionMode = RecognitionMode.MaxQuality;

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}


Result:

Code128: 096400674000080000243730

{{< /highlight >}}

BARCODENET-34064 Can't recognize QR code from the PDF document

Code sample

{{< highlight java >}}



string filename = @

".\Issues\Issue34064\img1.png"

;

string codeText =

"\|\|10\|31108977\|0100000034017\|PALETTI MARCO\|PLTMRC71P20C107P\|000\|A8\|V600109\|"

;

using ( BarCodeReader reader = new BarCodeReader (filename, (BarCodeReadType.QR)) )

{

reader.RecognitionMode = RecognitionMode.MaxQuality;

bool success = false;

while ( success = reader.Read () )

{

BarCodeReadType tp = reader.GetReadType ();

string txt = reader.GetCodeText ();

Console.WriteLine (

"Type:{0}, Text:{1}"

, tp, txt);

}

}

Console.WriteLine (

"Press any key to continue..."

);

Console.ReadKey ();

Result:

Type:QR, Text:\|\|10\|31108977\|0100000034017\|PALETTI MARCO\|PLTMRC71P20C107P\|000\|A8\|V600109\|


{{< /highlight >}}

BARCODENET-33859 Can't recognize unknown codes from tif image

Code sample

{{< highlight java >}}



using (BarCodeReader reader = new BarCodeReader(test.tif, BarCodeReadType.Code39Standard))

{

reader.RecognitionMode = RecognitionMode.ManualHints;

reader.ManualHints = ManualHint.IncorrectBarcodes\| ManualHint.UseRestoration;

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}


Result:

Code39Standard: CTSCASNY

Code39Standard: SUBLTR

Code39Standard: 141304

{{< /highlight >}}

BARCODENET-33636 Unable to recognize Pdf417 barcode after correct perspective problem

Code sample

{{< highlight java >}}



string filename = @

".\Issues\Issue33636\rotatedreduced_img_rotated.png"

;

string codeText = Encoding.Default.GetString (new byte[507] { 64, 10, 30, 13, 65, 78, 83, 73, 32, 54, 51, 54, 48, 49, 49, 48, 52, 48, 48, 48, 50, 68, 76, 48, 48, 52, 49, 48, 52, 54, 51, 90, 68, 48, 53, 48, 52, 48, 48, 48, 51, 68, 76, 68, 65, 81, 49, 54, 56, 54, 54, 53, 55, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 10, 68, 67, 83, 67, 72, 65, 75, 82, 65, 66, 79, 82, 84, 89, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 10, 68, 68, 69, 78, 10, 68, 65, 67, 83, 65, 85, 82, 65, 86, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 10, 68, 68, 70, 78, 10, 68, 65, 68, 78, 79, 78, 69, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 10, 68, 68, 71, 78, 10, 68, 67, 65, 68, 32, 32, 32, 32, 32, 10, 68, 67, 66, 66, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 10, 68, 67, 68, 78, 79, 78, 69, 32, 10, 68, 66, 68, 48, 55, 48, 54, 50, 48, 49, 50, 10, 68, 66, 66, 48, 51, 49, 54, 49, 57, 55, 57, 10, 68, 66, 65, 48, 51, 48, 53, 50, 48, 49, 52, 10, 68, 66, 67, 49, 10, 68, 65, 85, 48, 54, 55, 32, 105, 110, 10, 68, 65, 89, 66, 82, 79, 10, 68, 65, 71, 50, 52, 49, 52, 32, 83, 79, 67, 73, 69, 84, 89, 32, 68, 82, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 10, 68, 65, 73, 67, 76, 65, 89, 77, 79, 78, 84, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 10, 68, 65, 74, 68, 69, 10, 68, 65, 75, 49, 57, 55, 48, 51, 49, 55, 54, 49, 32, 32, 10, 68, 67, 70, 50, 48, 49, 50, 48, 55, 48, 54, 54, 56, 57, 53, 48, 57, 57, 49, 54, 56, 54, 54, 53, 55, 32, 32, 32, 10, 68, 67, 71, 85, 83, 65, 10, 68, 67, 85, 78, 79, 78, 69, 32, 10, 68, 65, 87, 49, 54, 49, 10, 68, 65, 72, 87, 72, 73, 84, 78, 69, 89, 32, 65, 80, 84, 83, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 10, 68, 68, 65, 77, 10, 68, 68, 66, 48, 50, 48, 56, 50, 48, 49, 48, 13, 90, 68, 13 });

using ( BarCodeReader reader = new BarCodeReader (filename, (BarCodeReadType.Pdf417)) )

{

reader.RecognitionMode = RecognitionMode.MaxQuality;

bool success = false;

while ( success = reader.Read () )

{

BarCodeReadType tp = reader.GetReadType ();

string txt = reader.GetCodeText ();

string tx = string.Format (

"File: '{0}', Type:{1}, Text:{2}"

, filename, tp, txt);

Console.WriteLine (tx);

}

}

Result:

File: '.\Issues\Issue33636\rotatedreduced_img_rotated.png',Type:Pdf417, Text:@

ANSI 636011040002DL00410463ZD05040003DLDAQ1686657

DCSCHAKRABORTY

DDEN

DACSAURAV

DDFN

DADNONE

DDGN

DCAD

DCBB

DCDNONE

DBD07062012

DBB03161979

DBA03052014

DBC1

DAU067 in

DAYBRO

DAG2414 SOCIETY DR

DAICLAYMONT

DAJDE

DAK197031761

DCF2012070668950991686657

DCGUSA

DCUNONE

DAW161

DAHWHITNEY APTS

DDAM

ZDB02082010

{{< /highlight >}}

BARCODENET-18901 EAN and PZN barcodes are not recognized correctly

Code sample

{{< highlight java >}}



string filename = String.Format(@

"306417_Barcode06.bmp"

);

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.PZN))

{

reader.RecognitionMode = RecognitionMode.MaxQuality;

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}

Result:

PZN: \-441055

{{< /highlight >}}

BARCODENET-15724 cannot recognize code39 barcode

Code sample

{{< highlight java >}}



string filename = @

".\Issues\Issue15724\out.jpg"

;

using ( BarCodeReader reader = new BarCodeReader (filename, (BarCodeReadType.AllSupportedTypes)) )

{

while ( reader.Read () )

{

BarCodeReadType tp = reader.GetReadType ();

string txt = reader.GetCodeText ();

string tx = string.Format (

"Type:{0}, Text:{1}"

, tp, txt);

Console.WriteLine (tx);

}

}

Result:

Type:Code39Standard, Text:07040-0000043893

{{< /highlight >}}

In case of RecognitionMode.MaxBarCodes

Code sample

{{< highlight java >}}

 string filename = @

".\Issues\Issue15724\out.jpg"

;

using ( BarCodeReader reader = new BarCodeReader (filename, (BarCodeReadType.AllSupportedTypes)) )

{

reader.RecognitionMode = RecognitionMode.MaxBarCodes;

while ( reader.Read () )

{

BarCodeReadType tp = reader.GetReadType ();

string txt = reader.GetCodeText ();

Console.WriteLine (string.Format (

"Type:{0}, Text:{1}"

, tp, txt));

}

}

Result:

Type:Code39Standard, Text:07040-0000043893

Type:Code39Standard, Text:MISCELLANEO

Type:Code39Standard, Text:07040-0000043893

{{< /highlight >}}
