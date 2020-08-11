---
title: Aspose.BarCode for .NET 6.9.0 Release Notes
type: docs
weight: 50
url: /net/aspose-barcode-for-net-6-9-0-release-notes/
---

The following is a list of improvements and changes in this release of Aspose.BarCode.
## **New features:**
BARCODENET-33954 Implement recognition rotated DataMatrix

BARCODENET-34054 Add support of Micro PDF417 code

BARCODENET-34060 Add decoding support of Micro QR code

BARCODENET-34124 Implement restructuring filters API

BARCODENET-34154 Add .NET 3.5 Client Profile version

BARCODENET-25063 Is it possible to generate a barcode like the attached image?
## **Enhancements:**
BARCODENET-34077 QR/Micro QR - encode/decode improvements

BARCODENET-22846 Code39 barcode could not be recognized from a scanned image

BARCODENET-33657 Unable to recognize Datamatrix bar codes from PNG files

BARCODENET-33810 Can't recognize DataMatrix code from png image

BARCODENET-33830 Can't recognize Code128 and DataMatrix codes in a single way

BARCODENET-33831 Can't recognize DataMatric code from a tif file

BARCODENET-33836 Can't recognize all DataMatrix codes from a tif file

BARCODENET-33839 Can't recognize all DataMatrix codes from a tif file

BARCODENET-33840 Can't recognize any DataMatrix code from a tif file

BARCODENET-33844 Can't recognize all DataMatrix codes from a tif file 

BARCODENET-33846 Can't recognize QR code from jpg image

BARCODENET-33855 Can't recognize QR code from jpg image without orientation angle

BARCODENET-33857 Incorrect recognition of the QR code from PNG image

BARCODENET-33919 Can't create Code128 barcode with standard 'f' character

BARCODENET-33984 Can't recognize QR code from the TIF image

BARCODENET-34003 Can't recognize all QR codes from the JPG image

BARCODENET-34017 Recognizing two Code128 codes instead of one

BARCODENET-34045 Add support of GS1 Databar coupon code generation

BARCODENET-34063 Spell mistake in XML of Aspose.BarCode API

BARCODENET-34068 Incorrect recognition of Pdf417 code from the tif image

BARCODENET-34070 Can't recognize QR code without Orientation Hints settings

BARCODENET-34080 Can't recognize DataMatrix code from the TIF file

BARCODENET-34084 Incorrect recognition of Code128 code from the tif image

BARCODENET-34092 Can't recognize a QR code from PDF document

BARCODENET-34096 Optimize the speed of recognition from the multipage tiff file format

BARCODENET-34099 Incorrect encoding punctuaion in PDF417 and MicroPDF417 barcodes

BARCODENET-34104 Incorrect recognition of Code128 code from the tif image

BARCODENET-34105 Incorrect recognition of Code128 code from the tif image

BARCODENET-34106 Incorrect recognition of Code128 code from the tif image

BARCODENET-34107 Incorrect recognition of Code128 code from the tif image

BARCODENET-34108 Incorrect recognition of Code128 code from the tif image

BARCODENET-34109 Can't recognize Ean13 code from the JPG image

BARCODENET-34112 Can't recognize Code39 code form the PDF document

BARCODENET-34113 Can't recognize PDF417 codeS from the PDF document

BARCODENET-34115 Can't recognize QR codes using error correction level

BARCODENET-34121 ?ode128 recognizer confuses f and "FNC1".

BARCODENET-34122 Can't recognize QR code from a JPG file

BARCODENET-34136 Public API changes with new QR/MicroQR decoder

BARCODENET-34137 Fake recognition of MicroPdf417

BARCODENET-34153 Extra letters in codetext when checksum off
## **Exceptions:**
BARCODENET-33990 Index out of range error message while generating a Code128 symbology

BARCODENET-34149 Stack overflow error while reading Code128 code from the tif image

Public API changes:

BARCODENET-25063 Is it possible to generate a barcode like the attached image?

Added new property FilledBars for BarCodeBuilder for generating filled or notfilled bars. This property works only with 1D barcodes. Default value is true (filled).

The following is an example of the new API usage:

{{< highlight java >}}

 using (BarCodeBuilder builder =

new

BarCodeBuilder(

"TEXT"

, Symbology.Code128))

{

builder.FilledBars =

false

;

builder.Save(fileName);

}

Result:



{{< /highlight >}}

BARCODENET-34054 Add support of Micro PDF417 code

Added support new symbology for generation - Micro PDF417.

The following is an example of the new API usage:

{{< highlight java >}}

 string codetext =

"12345"

;

using (BarCodeBuilder builder =

new

BarCodeBuilder(codetext, Symbology.MicroPdf417))

builder.Save(codetext +

".png"

);

Result:



{{< /highlight >}}

BARCODENET-34128 Implement ManualHints mode

{{< highlight java >}}

 Added new API:



Property Aspose.BarCodeRecognition.BarCodeReader.ManualHints



Class Aspose.BarCodeRecognition.ManualHint


Field/Enum Aspose.BarCodeRecognition.ManualHint.None





Field/Enum Aspose.BarCodeRecognition.ManualHint.InvertImage




Field/Enum Aspose.BarCodeRecognition.ManualHint.IncorrectBarcodes





Field/Enum Aspose.BarCodeRecognition.ManualHint.ComplexBackground




Allows you to configure options of recognition accuracy and speed manually. You need to change the property "RecognitionMode" to "RecognitionMode.ManualHints". Default value is None.





ManualHint.None - There are no heavy recognition algorithms. The fastest recognition algorithms are used there, however if image is noisy recognition will fail. Used by default.


ManualHint.InvertImage - Use when image is white on black background. Typically BarCode images are white on black background





ManualHint.IncorrectBarcodes - Addition algorithms are included to recognize incorrectly generated or damaged barcodes (skipped bars, stop symbol, etc).





ManualHint.ComplexBackground - Analyzes barcode background. Useful with complex or colored backgrounds.

reader.RecognitionMode = RecognitionMode.ManualHints;

reader.ManualHints = ManualHint.InvertImage\| ManualHint.IncorrectBarcodes;

{{< /highlight >}}

BARCODENET-34124 Implement restructuring filters API

New API:

{{< highlight java >}}



Property Aspose.BarCodeRecognition.BarCodeReader.RecognitionMode


Class Aspose.BarCodeRecognition.RecognitionMode




Field/Enum Aspose.BarCodeRecognition.RecognitionMode.MaxPerformance


Field/Enum Aspose.BarCodeRecognition.RecognitionMode.MaxQuality




Field/Enum Aspose.BarCodeRecognition.RecognitionMode.MaxBarCodes


Field/Enum Aspose.BarCodeRecognition.RecognitionMode.ManualHints



BarCodeReader.RecognitionMode allows to quickly set up and tune the processing speed and quality in a way which is the most appropriate for you needs. Default value is MaxPerformance.


RecognitionMode.MaxPerformance - finds all the possible good and average quality barcodes. Uses only the fastest algorithms. Enabled by default.



RecognitionMode.MaxQuality - finds all the possible barcodes with good or bad quality. Doesn't return potential barcodes. Uses different fast and slow algorithms.


RecognitionMode.MaxBarCodes - extends MaxQuality. Finds even potential barcodes. Uses extra algorithms which may recognize incorrect barcodes, barcodes on complex background, noisy or damaged barcodes and etc. You may observe extra spurious barcodes.



RecognitionMode.ManualHints - user configures hints optionally. Allows you to adjust the balance between speed and quality manually.

using (BarCodeReader reader =

new

BarCodeReader(

"differentBarcodes.png"

))

{

reader.RecognitionMode = RecognitionMode.MaxQuality;

while

(reader.Read()){

        Console.WriteLine(

"codetext: "

\+ reader.GetCodeText() +

"; type: "

\+ reader.GetReadType());

    }

}

{{< /highlight >}}

BARCODENET-34060 Add decoding support of Micro QR code

New API:

{{< highlight java >}}



Field/Enum Aspose.BarCodeRecognition.BarCodeReadType.MicroQR




Added support for Micro QR recognition.

BarCodeReader reader =

new

BarCodeReader(fileName, BarCodeReadType.MicroQR);

reader.Read();

string res = reader.GetCodeText();

reader.Close();

{{< /highlight >}}

BARCODENET-34136 Public API changes with new QR/MicroQR decoder

New API:

{{< highlight java >}}



Method Aspose.BarCodeRecognition.BarCodeReader.GetDetectEncoding



Method Aspose.BarCodeRecognition.BarCodeReader.SetDetectEncoding(System.Boolean)



In case the flag is enabled the barcode engine returns Unicode text while tries to detect the encoding of the barcode. The barcode may be encoded using one of the following encodings:


UTF8




BOM_UTF8




BOM_UTF16BE



BOM_UTF16LE


The flag is enabled by default. In case the flag is disabled the engine returns plain text without encoding detection.



The flag works for QR/Micro QR at the moment.


MemoryStream ms =

new

MemoryStream();

using (BarCodeBuilder bb =

new

BarCodeBuilder())

{

bb.CodeText =

"?????"

;

bb.SymbologyType = Symbology.QR;

bb.CodeTextEncoding = Encoding.UTF8;

bb.Save(ms, BarCodeImageFormat.Png);

}

using (BarCodeReader reader =

new

BarCodeReader(ms, BarCodeReadType.QR))

{

reader.SetDetectEncoding(

true

);

if

(reader.Read())

Console.WriteLine(reader.GetCodeText()));

// "?????"

}

MemoryStream ms =

new

MemoryStream();

using (BarCodeBuilder bb =

new

BarCodeBuilder())

{

bb.CodeText =

"?????"

;

bb.SymbologyType = Symbology.QR;

bb.CodeTextEncoding = Encoding.UTF8;

bb.Save(ms, BarCodeImageFormat.Png);

}

using (BarCodeReader reader =

new

BarCodeReader(ms, BarCodeReadType.QR))

{

reader.SetDetectEncoding(

false

);

if

(reader.Read())

Console.WriteLine(reader.GetCodeText(Encoding.UTF8));

// "?????"

}

{{< /highlight >}}
