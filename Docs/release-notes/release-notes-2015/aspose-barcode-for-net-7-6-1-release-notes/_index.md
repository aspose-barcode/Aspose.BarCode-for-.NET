---
title: Aspose.BarCode for .NET 7.6.1 Release Notes
type: docs
weight: 10
url: /net/aspose-barcode-for-net-7-6-1-release-notes/
---

The list of improvements and changes that are released in Aspose.BarCode .NET as follows:
## **New Features**
BARCODENET-34345 Recognize datamatrix with decorated modules

BARCODENET-34345 Recognize datamatrix with decorated modules

BARCODENET-34315 Implement recognition of dot peen datamatrix (rotated)

BARCODENET-34315 Implement recognition of dot peen datamatrix (rotated)

BARCODENET-13003 Export / Import BarCode property to / from xml - file

BARCODENET-13003 Export / Import BarCode property to / from xml - file
## **Enhancements**
BARCODENET-34337 Add generatorBase parameter to the ReedSolomon encoder/decoder.

BARCODENET-34337 Add generatorBase parameter to the ReedSolomon encoder/decoder.

BARCODENET-34332 Fake recognition of MicroPdf417 in picture with Code128

BARCODENET-34332 Fake recognition of MicroPdf417 in picture with Code128

BARCODENET-34329 Unable to recognize Code39Standard barcode in a win-form application [.Net](/pages/createpage.action?spaceKey=barcodenet&title=.Net&linkCreation=true&fromPageId=12944646)

BARCODENET-34328 Unable to recognize QR barcode from Pdf file [.Net](/pages/createpage.action?spaceKey=barcodenet&title=.Net&linkCreation=true&fromPageId=12944646)

BARCODENET-34326 Dashed dot peen datamatrix

BARCODENET-34326 Dashed dot peen datamatrix

BARCODENET-34325 Unable to recognize the Code128 Barcode in Windows Application [.Net](/pages/createpage.action?spaceKey=barcodenet&title=.Net&linkCreation=true&fromPageId=12944646)

BARCODENET-34317 Not able to recognize barcode in a Windows Forms Application

BARCODENET-34314 barcode Engine is not recognizing symbology : Code39Standard Barcode

BARCODENET-34306
BarCodeReader Class GetAngle Method Returns inconsistent results, Some
time returns integer value and some time float

BARCODENET-34287 Can't recognize Datamatrix code from the PNG image

BARCODENET-34286 Can't recognize Datamatrix code from the PNG image

BARCODENET-33842 Can't recognize all DataMatrix/Code128 codes from a tif file

Exceptions

BARCODENET-34355 Aspose.BarCode for .Net 7.6.0 shows error: This copy of 'Aspose.BarCode' has expired and will no longer run

BARCODENET-33641 Exception occurs when load web page with barcode (WPF)

BARCODENET-33641 Exception occurs when load web page with barcode (WPF)

Usage examples:

BARCODENET-34345 Recognize datamatrix with decorated modules

Code sample

{{< highlight java >}}



string filename = @

"datamatrix-stars.png"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.DataMatrix))

{

reader.RecognitionMode = RecognitionMode.ManualHints;

reader.ManualHints = ManualHint.SpecialFormOfCells;

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}

result:



DataMatrix: StarDatamatrix


DataMatrix: StarDatamatrix

{{< /highlight >}}

BARCODENET-34315 Implement recognition of dot peen datamatrix (rotated)

Now datamatrix is recognized by "MaxQuality" mode or "SpecialFormOfCells" manual hints

Code sample:

{{< highlight java >}}



string filename = @

"G:\prj\aspose\Barcode.Net.Git\Aspose.BarCode.NET\testdata\Issues\Issue34315\test2.png"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.DataMatrix))

{

reader.RecognitionMode = RecognitionMode.ManualHints;

reader.ManualHints = ManualHint.SpecialFormOfCells;

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}

result:


result:

DataMatrix: BERMA Macchine Budrio (BO)

DataMatrix: BERMA Macchine Budrio (BO)

DataMatrix: BERMA Macchine Budrio (BO)

DataMatrix: BERMA Macchine Budrio (BO)

DataMatrix: BERMA Macchine Budrio (BO)

DataMatrix: BERMA Macchine Budrio (BO)

{{< /highlight >}}

BARCODENET-13003 Export / Import BarCode property to / from xml - file

ExportToXml(<The name of the file to export properties>)

Exports the BarCodeBuilder properties into XML-file with the name specified.

Returns true if the file has been successfully created; false otherwise;

Code sample:

{{< highlight java >}}

 BarCodeBuilder builder = new BarCodeBuilder(

"abcdefghijklmnopqrstuvwxyzabcdef"

, Symbology.DataMatrix);

builder.BorderVisible = true;

builder.ImageQuality = ImageQualityMode.AntiAlias;

builder.CodeLocation = CodeLocation.Above;

builder.Columns = 4;

builder.Rows = 3;

builder.CaptionAbove = new Caption(

"{Caption ABOVE}"

);

builder.CaptionAbove.TextAlign = System.Drawing.StringAlignment.Center;

builder.CaptionAbove.Visible = true;

builder.CaptionAbove.ForeColor = Color.Green;

builder.CaptionBelow = new Caption(

"{Caption BELOW}"

);

builder.CaptionBelow.TextAlign = System.Drawing.StringAlignment.Far;

builder.CaptionBelow.Visible = true;

builder.CaptionBelow.ForeColor = Color.Yellow;

builder.CodeTextFont = new Font(

"Courier New"

, 24, FontStyle.Bold \| FontStyle.Italic);

string fileNameTmp = Path.Combine(@

"C:\TEMP"

,

"BarCodeBuilder.DataMatrix.xml"

);

builder.ExportToXml(fileNameTmp);

This sample has resulted in:

<?xml version="1.0" encoding="utf-8"?>

<Aspose.BarCode.Builder.Properties

SymbologyType="DataMatrix"

BorderColor="Black"

ForeColor="Black"

BackColor="White"

CodeTextColor="Black"

ImageQualityMode="AntiAlias"

CodeLocation="Above"

CodabarStartSymbol="A"

CodabarStopSymbol="A"

Rotation="0"

AutoSize="True">

<CodeText>abcdefghijklmnopqrstuvwxyzabcdef</CodeText>

<CodeTextEncoding>1251</CodeTextEncoding>

<FilledBars>true</FilledBars>

<BorderVisible>true</BorderVisible>

<CodeTextFont>Courier New; 24pt; style=Bold, Italic</CodeTextFont>

<Columns>4</Columns>

<Rows>3</Rows>

<ResolutionValue>

<Resolution

DpiX="96"

DpiY="96"

Mode="Graphics" />

</ResolutionValue>

<CaptionAbove>

<Caption

ForeColor="Green"

Text="{Caption ABOVE}"

Visible="True"

TextAlign="Center"

Space="1"

Font="Microsoft Sans Serif; 8pt" />

</CaptionAbove>

<CaptionBelow>

<Caption

ForeColor="Yellow"

Text="{Caption BELOW}"

Visible="True"

TextAlign="Far"

Space="1"

Font="Microsoft Sans Serif; 8pt" />

</CaptionBelow>

<Margins>

<MarginsF

Bottom="1"

Left="4"

Right="4"

Top="1" />

</Margins>

</Aspose.BarCode.Builder.Properties>

ImportFromXml(<The name of the file to import properties>)



Imports BarCodeBuilder properties from the XML-file specified for further BarCode building.





Returns new instance of BarCodeBuilder;

{{< /highlight >}}

Code sample:

{{< highlight java >}}

 string fileNameTmp = Path.Combine(

"C:\TEMP"

,

"BarCodeBuilder.DataMatrix.xml"

);

BarCodeBuilder imported = BarCodeBuilder.ImportFromXml(fileName);

Bitmap bmp = imported.GenerateBarCodeImage();

ExportToXml(<The name of the file to export properties>)


ExportToXml(<The name of the file to export properties>)

Exports the BarCodeReader properties into XML-file with the name specified.


Exports the BarCodeReader properties into XML-file with the name specified.



Returns true if the file has been successfully created; false otherwise;


Returns true if the file has been successfully created; false otherwise;

{{< /highlight >}}

Code sample:

{{< highlight java >}}



string xmlFileNameTmp = Path.Combine(

"C:\TEMP"

,

"BarCodeReader.DataMatrix.xml"

);

BarCodeReader reader = new BarCodeReader(imgFilename, BarCodeReadType.DataMatrix);

reader.ExpectedBarCodeCount = 1;

reader.ChecksumValidation = ChecksumValidation.Off;

reader.RecognitionMode = RecognitionMode.MaxQuality;

if (reader.ExportToXml(xmlFileNameTmp))

{

Concolse.WriteLine(

"BarCodeReader.ExportToXml('file') export has failed."

);

}

This sample has resulted in:

<?xml version="1.0" encoding="utf-8"?>

<Aspose.BarCode.Reader.Properties

BarCodeReadType="DataMatrix"

ImageFileName="C:\TEMP\BarCodeReader.DataMatrix.xml"

RecognitionMode="MaxQuality"

ManualHints="None"

OrientationHints="NoRotate">

<ChecksumValidation>Off</ChecksumValidation>

<ExpectedBarCodeCount>1</ExpectedBarCodeCount>

<MedianSmoothingWindowSize>3</MedianSmoothingWindowSize>

<Timeout>0</Timeout>

<StripFNC>false</StripFNC>

</Aspose.BarCode.Reader.Properties>

ImportFromXml(<The name of the file to export properties>)




Imports BarCodeReader properties from the XML-file specified for further BarCode reading.






Returns new instance of BarCodeReader;

{{< /highlight >}}

Code sample:

{{< highlight java >}}



string xmlFileNameTmp = Path.Combine(

"C:\TEMP"

,

"BarCodeReader.DataMatrix.xml"

);

BarCodeReader imported = BarCodeReader.ImportFromXml(xmlFileNameTmp);

if (imported == null)

{

Concolse.WriteLine(

"BarCodeReader.ImportFromXml('file') import has not created the instance correctly."

);

return;

}

while (imported.Read())

{

Concolse.WriteLine(

"Type: {0}; BarCode Text: {1}"

, imported.GetReadType(), imported.GetCodeText());

}

{{< /highlight >}}

BARCODENET-34332 Fake recognition of MicroPdf417 in picture with Code128

Sample code:

{{< highlight java >}}



using (BarCodeReader reader =

new

BarCodeReader(filename))

{

while

(reader.Read()){

        string sResult = reader.GetReadType() +

": "

\+ reader.GetCodeText();

        Console.WriteLine(sResult);

    }

}

Result:

Code128: CC10DAF


{{< /highlight >}}

BARCODENET-34328 Unable to recognize QR barcode from Pdf file [.Net](/pages/createpage.action?spaceKey=barcodenet&title=.Net&linkCreation=true&fromPageId=12944646)

Code sample

{{< highlight java >}}



string filename = @

"DOC161115-010_1_Erros.png"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.QR))

{

reader.RecognitionMode = RecognitionMode.MaxQuality;

// try use the median smoothing hint to recognize more faster.

// reader.RecognitionMode = RecognitionMode.ManualHints;

// reader.ManualHints = ManualHint.MedianSmoothing;

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}

Result:

\#SDY-LABEL#IdPastaClassificacao=1;Natureza=3;IdTipoDocumento=6;Empresa=4;Ano=2;Seccao=5;TipoDocumento=11;NumDocumento=1500552;FileName-Label=ERP$005$EX 2015$2$VFAT$1500552

{{< /highlight >}}

BARCODENET-34326 Dashed dot peen datamatrix

Code sample:

{{< highlight java >}}



using (BarCodeReader reader = new BarCodeReader(

"DotPeenDashed1.png"

, BarCodeReadType.DataMatrix))

{

reader.RecognitionMode = RecognitionMode.ManualHints;

reader.ManualHints = ManualHint.SpecialFormOfCells;

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}

Result:

DataMatrix: 250623022021032007010300

{{< /highlight >}}

BARCODENET-34325 Unable to recognize the Code128 Barcode in Windows Application [.Net](/pages/createpage.action?spaceKey=barcodenet&title=.Net&linkCreation=true&fromPageId=12944646)

Sample code:

{{< highlight java >}}



string filename = @

"C:\barcode_files\Barcode128.png"

;

using (BarCodeReader reader =

new

BarCodeReader(filename, BarCodeReadType.Code128))

{

while

(reader.Read())

{

string sResult = reader.GetReadType() +

": "

\+ reader.GetCodeText();

//....

}

}

Output (sResult string is):


{{< /highlight >}}

Code128: CC10DAF

BARCODENET-34314 barcode Engine is not recognizing symbology : Code39Standard Barcode

Code samle:

{{< highlight java >}}



string filename = @

"bar.png"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.Code39Standard \| BarCodeReadType.Code39Extended))

{

while (reader.Read()){

		Console.WriteLine(

"CodeText: "

\+ reader.GetCodeText());

	}

}

Result:

CodeText: 15-07672


{{< /highlight >}}

BARCODENET-34306 BarCodeReader Class GetAngle Method Returns inconsistent results, Some time returns integer value and some time
float

Code sample

{{< highlight java >}}



for (int iCunt = 1; iCunt <= 6; iCunt++)

{

string barcodeFile = @

"C:\Input\getangle_test"

\+ iCunt.ToString() +

".tif"

;

Aspose.BarCodeRecognition.BarCodeReader reader = new Aspose.BarCodeRecognition.BarCodeReader(

barcodeFile, Aspose.BarCodeRecognition.BarCodeReadType.QR);

while (reader.Read()){

		double rotationValue = reader.GetAngle();

		Console.WriteLine(rotationValue.ToString());

	}

reader.Close();

}

Result:


Result:

0,927611470222473

3,39229941368103

90,0077056884766

180,480224609375

270,355438232422

187,250411987305


{{< /highlight >}}

BARCODENET-34287 Can't recognize Datamatrix code from the PNG image

Code sample

{{< highlight java >}}



string filename = @

"G:\prj\aspose\Barcode.Net.Git\Aspose.BarCode.NET\testdata\Issues\Issue34287\Laser2.PNG"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.DataMatrix))

{

reader.RecognitionMode = RecognitionMode.MaxQuality;

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}

Result:

DataMatrix: D19-WQ9-F91046-0811


{{< /highlight >}}

BARCODENET-34286 Can't recognize Datamatrix code from the PNG image

Code sample

{{< highlight java >}}



string filename = @

"Laser1.PNG"

;

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.DataMatrix))

{

reader.RecognitionMode = RecognitionMode.MaxQuality;

while (reader.Read()){

		Console.WriteLine(reader.GetReadType() +

": "

\+ reader.GetCodeText());

	}

}

Result:

DataMatrix: D19-WQ9-F91046-0811


{{< /highlight >}}
