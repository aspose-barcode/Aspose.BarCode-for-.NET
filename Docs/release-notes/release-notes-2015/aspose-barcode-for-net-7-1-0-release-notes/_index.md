---
title: Aspose.BarCode for .NET 7.1.0 Release Notes
type: docs
weight: 30
url: /net/aspose-barcode-for-net-7-1-0-release-notes/
---

The list of improvements and changes in Aspose.BarCode .NET as follows:

The list of improvements and changes in Aspose.BarCode .NET as follows:
## **New Features**
BARCODENET-33994 Review and include ECC000-140 algorithm into main project
## **Enhancements**
BARCODENET-33156 Flag to indicate that a barcode is found but unreadable

BARCODENET-34220 The duplicate recognition of the datamatrix

BARCODENET-34206 Incorrect recognition when lines restoration is used

BARCODENET-34190 Incorrect barcode read type for SwissPostParcel filter

BARCODENET-34181 Incorrect recognition of Planet code from the tif image

BARCODENET-34180 Incorrect recognition of Planet code from the tif image

BARCODENET-34094 Can't recognize Aztec code from the PDF document

BARCODENET-34093 Can't recognize Aztec code from the PDF document

BARCODENET-33974 Can't recognize DataMatrix code from the JPG image

BARCODENET-33938 Can't recognize Code39 code from the tif file

BARCODENET-33892 Can't recognize Code39 barcodes from the PDF document

BARCODENET-33856 SSCC18 symbology, check digit should be in parenthesis

BARCODENET-33853 Error message when tried to encode Code128 with FNC 3 character

BARCODENET-33804 Incorrect recognition of DataMatrix code from a PNG file

BARCODENET-33544 Incorrect Or Unable to recognize bar codes from a PDF file format

BARCODENET-33536 Aspose is compatible with ECC 000 - 140 and ECC 200
## **Exceptions**
BARCODENET-34204 Correct the GetRegion function for DatabarExpandedStacked

Usage examples:

The flag indicating that an unreadable barcode has been detected on the image

Code sample:

{{< highlight java >}}



Bitmap lOrigBmp = new Bitmap(

"Path to File"

);

BarCodeReader reader = new BarCodeReader(lOrigBmp);

reader.SetBarCodeReadType(BarCodeReadType.QR);

//1.method max barcodes mode

reader.RecognitionMode = RecognitionMode.MaxBarCodes;

//2.method manual hints mode

//reader.RecognitionMode = RecognitionMode.ManualHints;

//reader.ManualHints = ManualHint.IncorrectBarcodes;

while (reader.Read())

{

bool isFake = reader.GetIsDeniable();

string lStr = reader.GetReadType().ToString() +

" IsFake:"

\+ isFake.ToString() +

" CodeText:"

\+ reader.GetCodeText();

MessageBox.Show(lStr);

}

lOrigBmp.Dispose();

Another sample:




string filename = @

"G:\prj\aspose\Barcode.Net\testdata\Issues\Issue34189\skipped2.png"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.Code128))

{

reader.RecognitionMode = RecognitionMode.MaxBarCodes;

while (reader.Read()){

          Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

          Console.WriteLine(

"IsDeniable: "

\+ reader.GetIsDeniable());

      }

}

Result:

Code128: A;000000014941 IsDeniable: True

Review and include  ECC000-140 algorithm into main project

Code sample:


// Generate

BarCodeBuilder builder1 = new BarCodeBuilder();

builder1.SymbologyType = Symbology.DataMatrix;

builder1.DatamatrixEcc = DataMatrixEccType.Ecc050;

builder1.CodeText =

"BASE-41 ONLY ALPHA, DIGITS AND PUNCTUATION."

;

builder1.Save(

"Barcode1.png"

);

BarCodeBuilder builder2 = new BarCodeBuilder();

builder2.SymbologyType = Symbology.DataMatrix;

builder2.DatamatrixEcc = DataMatrixEccType.Ecc050;

builder2.CodeText =

"ASCII encodes first 128 chars."

;

builder2.Save(

"Barcode2.png"

);

// Recognize

using (BarCodeReader reader = new BarCodeReader(

"Barcode1.png"

, BarCodeReadType.DataMatrix))

{

while (reader.Read()){

		Console.WriteLine(

"Barcode1.png:  "

\+ reader.GetCodeText());

	}

}

using (BarCodeReader reader = new BarCodeReader(

"Barcode2.png"

, BarCodeReadType.DataMatrix))

{

while (reader.Read()){

		Console.WriteLine(

"Barcode2.png:  "

\+ reader.GetCodeText());

	}

}

Result:



{{< /highlight >}}

Barcode1.png: BASE-41 ONLY ALPHA, DIGITS AND PUNCTUATION.
Barcode2.png: ASCII encodes first 128 chars.

The duplicate recognition of the datamatrix

Code sample:

{{< highlight java >}}



string filename = @

"Page5.png"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.DataMatrix))

{

while (reader.Read())

{

Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

for (int i = 0; i < reader.GetRegion().Points.Length; i++){

			Console.WriteLine(reader.GetRegion().Points[i]);

		}

}

}

Result:

DataMatrix: GAC2014-997002

{X=1826,Y=948}

{X=1721,Y=948}

{X=1826,Y=1048}

{X=1721,Y=1048}

Recognition when lines restoration is used

Code sample:

string filename = @

"C:\prj\Aspose\Project\testdata\Issues\Issue34206\33453_Image+1.TIF"

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


using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.Code128))

{

reader.ImageBinarizationHints = RecognitionHints.ImageBinarization.LineCodesRestoration;

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}

Result:

Code128: H00123192899A

{{< /highlight >}}

Barcode read type for SwissPostParcel filter

Code sample

{{< highlight java >}}



string filename = @

"C:\Users\oygan\Downloads\BARCODENET-34190\SwissPostParcel.png"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.SwissPostParcel))

{

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}

result:

SwissPostParcel: 994299671234561789

Recognize Aztec code from the PDF document

Code sample

string filename = @

"G:\prj\aspose\Barcode.Net\testdata\Issues\Issue34093\Page7.png"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.Aztec))

{

//reader.RecognitionMode = RecognitionMode.MaxBarCodes;

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}

result:


result:

Aztec: Gomaro Aztec [http://www.gomaro.ch/Code_Aztec.htm]

Recognize DataMatrix code from the JPG image

Matrix is inverted.


Matrix is inverted.


Code sample:

BarCodeReader reader = new BarCodeReader(@

"C:\Users\DNS\Downloads\BARCODENET-33974\DataMatrix_1.jpg"

, BarCodeReadType.DataMatrix);

reader.RecognitionMode = RecognitionMode.ManualHints;

reader.ManualHints = ManualHint.InvertImage;

while (reader.Read())

{

Console.WriteLine(

"Type: "

\+ reader.GetReadType() +

"  Code: "

\+ reader.GetCodeText());

}

reader.Close();

result:

Type: DataMatrix  Code: UMT471120001047

Recognize Code39 code from the tif file

Code sample


string filename = @

"G:\prj\aspose\Barcode.Net\testdata\Issues\Issues33938\3.tif"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.Code39Standard \| BarCodeReadType.QR))

{

//reader.RecognitionMode = RecognitionMode.MaxBarCodes;

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}

result:

Code39Standard: SEPARATOR

QR: CapitalStream Document ID: 3372291970265819248, Coversheet Indicator: Y, Document Source System: CS

Recognize Code39 barcodes from the PDF document

Code sample


string filename = @

"G:\prj\aspose\Barcode.Net\testdata\Issues\Issue33892\Page1.png"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.Code39Extended \| BarCodeReadType.Code39Standard))

{

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}

result:

Code39Standard: BA2479046

Code39Extended: BA2479046aR0002      \+04202013+03202013

Error message when tried to encode Code128 with FNC 3 character

Code sample:

BarCodeBuilder builder = new BarCodeBuilder();

char FNC3 = Convert.ToChar(201);

builder.CodeText = FNC3 +

"1234567"

;

builder.SymbologyType = Symbology.Code128;

MemoryStream code128 = new MemoryStream();

builder.Save(code128, BarCodeImageFormat.Png);

new Bitmap(code128).Save(

"code128.png"

);

Result:


picture"code128.png" is attached.

Recognition of DataMatrix code from a PNG file

Code sample


string filename = @

"G:\prj\aspose\Barcode.Net\testdata\Issues\Issue33804\false_positive.png"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.DataMatrix))

{

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}

result:

DataMatrix: E200A05B520086C93E11BCA863028B412

Recognize bar codes from a PDF file format

Code sample:

for (int i = 1; i <= 8; i++)

{

string filePath = @

"C:\AB\test84\imgs\Page"

\+ i + png";

using (BarCodeReader reader = new BarCodeReader(filePath, BarCodeReadType.DataMatrix))

{

if (i >= 2 && i <= 5)

reader.RecognitionMode = RecognitionMode.MaxQuality;

while (reader.Read()){

			Console.WriteLine(Path.GetFileName(filePath) +

" -- Symbol: "

\+ reader.GetReadType() +

" Code:  "

\+ reader.GetCodeText());

		}

}

}

Result:


Page1.png -- Symbol: DataMatrix Code:  :AAAB7DWG0TzWBA

Page2.png -- Symbol: DataMatrix Code:  :AAAB7DWG0TzWBA

Page3.png -- Symbol: DataMatrix Code:  :AAAB7DWG0TzWBA

Page4.png -- Symbol: DataMatrix Code:  :AAAB7DWG0TzWBA

Page5.png -- Symbol: DataMatrix Code:  :AAAB7DWG0TzWBA

Page5.png -- Symbol: DataMatrix Code:  (p1:AAAB7DWG0TzWBA)SA20130514a\|X:60;Opt:OR;COESA:0%;AP:ApAct;U:UK;COEGL:0%;PV:PI;RG:RUC;CST:None;ACLim:AEMP;YY:IMS-EILP

Page6.png -- Symbol: DataMatrix Code:  :AAAB7DNGiKyRNg

Page7.png -- Symbol: DataMatrix Code:  :AAAB7DNGiKyRNg

Page8.png -- Symbol: DataMatrix Code:  (p1:AAAB7DNGiKyRNg)SA20130514a\|X:60;Opt:OR;COESA:0%;AP:ApAct;U:UK;COEGL:0%;PV:PI;RG:RUC;CST:None;ACLim:AEMP;YY:IMS-EILP

Page8.png -- Symbol: DataMatrix Code:  :AAAB7DNGiKyRNg

Correct the GetRegion function for DatabarExpandedStacked

Supported GetRegion function for the all "stacked" databars


Code sample

string filename = @

"G:\prj\aspose\Barcode.Net\testdata\Issues\Issue34204\DatabarExpandedSTacked.png"

;

using (BarCodeReader reader = new BarCodeReader(filename))

{

while (reader.Read())

{

Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

for (int i = 0; i < reader.GetRegion().Points.Length; i++)

{			Console.WriteLine(reader.GetRegion().Points[i]);		}

}

}

filename = @

"G:\prj\aspose\Barcode.Net\testdata\Issues\Issue34204\DatabarStacked.png"

;

using (BarCodeReader reader = new BarCodeReader(filename))

{

while (reader.Read())

{

Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

for (int i = 0; i < reader.GetRegion().Points.Length; i++){

			Console.WriteLine(reader.GetRegion().Points[i]);

		}

}

}

result:


DatabarExpandedStacked: (01)95012345678903(3103)000123

{X=0,Y=0}

{X=203,Y=0}

{X=203,Y=141}

{X=0,Y=141}

DatabarStackedOmniDirectional: (01)2401234567890

{X=16,Y=16}

{X=117,Y=16}

{X=117,Y=42}

{X=16,Y=42}

{{< /highlight >}}
