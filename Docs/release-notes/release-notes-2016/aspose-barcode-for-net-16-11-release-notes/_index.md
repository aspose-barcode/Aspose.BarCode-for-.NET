---
title: Aspose.BarCode for .NET 16.11 Release Notes
type: docs
weight: 30
url: /net/aspose-barcode-for-net-16-11-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for Aspose.BarCode for .NET 16.11.

{{% /alert %}} 
### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|BARCODENET-36304 |Add support of the new BarCode type: Codablock F|New Feature|
|BARCODENET-36340 |Add support GS1 for CodablockF|New Feature|
|BARCODENET-36356 |[Add support of AI 8012](http://www.aspose.com/community/forums/thread/791673/feature-request-support-for-ai-8012.aspx)|New Feature|
|BARCODENET-36357 |Add support of the classification of the encode types (symbologies)|New Feature|
|BARCODENET-36349 |Add support of more than 64 types to the encoder API|New Feature|
|BARCODENET-33878 |[Slow recognition speed when reading QR codes from multi-page Tiff](http://www.aspose.com/community/forums/thread/536290/read-write-qr-codes-from-scanned-pdf-and-scanned-tiff-are-very-time-consuming-calls.aspx)|Enhancement |
|BARCODENET-33909 |[Can't recognize QR codes through free QR scanner apps available on the app store](http://www.aspose.com/community/forums/thread/527926/not-able-to-scan-generated-qr-code-using-aspose.aspx)|Enhancement |
|BARCODENET-36344 |[Correct the bits in datamatrix recognition](http://www.aspose.com/community/forums/thread/717058/issues-detecting-datamatrix-barcodes.aspx)|Enhancement |
|BARCODENET-36234 |[Exception while trying to generate PDF417 barcode](http://www.aspose.com/community/forums/thread/741392/pdf417-supported-characters-in-text-compaction-mode.aspx)|Enhancement |
|BARCODENET-36348 |[PDF417 coded Barcode recognition is not working](http://www.aspose.com/community/forums/thread/788320/pdf-417-recognition-problem.aspx)|Enhancement |
|BARCODENET-36347 |Improve recognition rotated MicroQr barcodes|Enhancement |
# **Usage examples:**
**BARCODENET-36349 Add support of more than 64 Symbologies to the Encoder API**

How to build a barcode:

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder("3-5-7-11", EncodeTypes.Code128);

builder.Save("barcode.png");

{{< /highlight >}}

Another sample:

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder();

builder.CodeText = "3-5-7-11";

builder.EncodeType = EncodeTypes.Code128;

builder.Save("barcode.png");

{{< /highlight >}}

How to obtain all the EncodeTypes:

{{< highlight xml >}}

 BaseEncodeType[] allTypes = EncodeTypes.AllEncodeTypes;

{{< /highlight >}}

How to parse EncodeTypes from the string:

{{< highlight xml >}}

 BaseEncodeType symbology;

bool successful = false;

successful  = EncodeTypes.Parse("Code128", out symbology);

Console.WriteLine(successful);

successful = EncodeTypes.TryParse("Index:33;Name:DataMatrix", out symbology);

Console.WriteLine(successful);

{{< /highlight >}}

**BARCODENET-36357 Add support of the classification of the encode types (symbologies)**

How to get the *Type2D* symbologies only:

{{< highlight xml >}}

 foreach (BaseEncodeType encodeType in EncodeTypes.AllEncodeTypes)

{

    if (encodeType.Classification == BarcodeClassifications.Type2D)

       Console.WriteLine(encodeType.TypeName);

}

{{< /highlight >}}

Result:

{{< highlight xml >}}

 DataMatrix

QR

Aztec

Pdf417

MacroPdf417

GS1DataMatrix

MicroPdf417

GS1QR

MaxiCode

DotCode

{{< /highlight >}}

**BARCODENET-36304 Add support of the new BarCode type: Codablock F**

Sample generation code:

{{< highlight xml >}}

 BarCodeBuilder b = new BarCodeBuilder();

b.CodeText = "CODABLOCKF 01234567890123456789012digits";

b.EncodeType = EncodeTypes.CodablockF;

b.BarCodeImage.Save("CodablockF.png");

{{< /highlight >}}

Sample generation code with specific rows and columns:

{{< highlight xml >}}

 BarCodeBuilder b = new BarCodeBuilder();

b.CodeText = "CODABLOCKF 01234567890123456789012digits";

b.EncodeType = EncodeTypes.CodablockF;

b.Rows = 7;

b.Columns = 7;

b.BarCodeImage.Save("CodablockF_7rows_7cols.png");

{{< /highlight >}}

Sample:

{{< highlight xml >}}

 string filename = "Codablock-F_Example.png";

using (BarCodeReader reader = new BarCodeReader(filename, DecodeType.CodablockF))

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

Sample generation code:

{{< highlight xml >}}

 BarCodeBuilder b = new BarCodeBuilder();

b.CodeText = "(01)03412345678900(17)010200";

b.EncodeType = EncodeTypes.GS1CodablockF;

b.BarCodeImage.Save("GS1CodablockF.png");

{{< /highlight >}}

Sample recognition code:

{{< highlight xml >}}

 string filename = "GS1CodablockF.png";

using (BarCodeReader reader = new BarCodeReader(filename, DecodeType.CodablockF))

{

    while (reader.Read())

    {

        Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());

    }

}

{{< /highlight >}}

Result:

{{< highlight xml >}}

 CodablockF: (01)03412345678900(17)010200

{{< /highlight >}}

**BARCODENET-33909 Can't recognize QR codes through free QR scanner apps available on the app store** 
QRCodeComparison.pdf has resolution 96.
Size of the small barcode is 132x121 px. But the dimension is 125.
It is not really recognizable without zoom.

Size of the larger barcode is 264x242 px.

Recommended size has been calculated with the formula: (assuming the scanning distance is about 6 inch.)
recommended size of QR = (6*125)/250 = 3 inches.
Size of large image (old code) is 2.75 inches.
Size of small image (new code) is 1.38 inches.
The formula was taken from the following [web-page](https://scanova.io/blog/blog/2015/02/20/qr-code-minimum-size/)

Method GetOnlyBarcodeImage uses 1px module by default, so the output image is too small.

Both methods builder.Save() and builder.GetOnlyBarCodeImage() can generate QR with large codetext.

To generate readable size barcode with GetOnlyBarCodeImage function, use scale parameter.

{{< highlight xml >}}

 string text = "";

for (int i = 0; i < 4296; i++)

{

	text += "A";

}

BarCodeBuilder builder = new BarCodeBuilder(text, Symbology.QR);

int scale = 2;

Bitmap bitmap = builder.GetOnlyBarCodeImage(scale);

bitmap.Save("scaled.png");

{{< /highlight >}}

**BARCODENET-36344 Correct the bits in datamatrix recognition** 
Code sample

{{< highlight xml >}}

 string filename ="DataMatrix10.tiff";

BarCodeReader reader = new BarCodeReader(filename);

while (reader.Read())

{

	Console.WriteLine("-- Symbol:" + reader.GetCodeType() + " Code :" + reader.GetCodeText());

}

reader.Close();

{{< /highlight >}}

Result:

{{< highlight xml >}}

 -- Symbol:DataMatrix Code :424D4A414E31364252435467303318443847AAC44B7A7D0138A6909EFCB580BEE0FDBF22D5A8F3007322

{{< /highlight >}}

**BARCODENET-36234 Exception while trying to generate PDF417 barcode** 
The first Code sample:

BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

barCodeBuilder.CodeText = "1F7D07D7-3E81-4DE4-AEA7-58DDE1D93857\r\n\r\n;L;L SFSDF FDSLKKPPÊFMKJ KJSDF; K F DSHFKDSLKF JJ2,;LL;0932=09=**&$#@$#@#(*& DSFKDJFDS;LFSAKJDF;LLKJF\r\nHELLO WORLD";

barCodeBuilder.SymbologyType = Symbology.Pdf417;

barCodeBuilder.Pdf417CompactionMode = Pdf417CompactionMode.Text;

barCodeBuilder.Save(@"Pdf417_fixed1.png");

Result:

{{< highlight xml >}}

 Aspose.BarCode.BarCodeException : Unsupported char in Text mode: Ê at index 59

{{< /highlight >}}

The second Code sample:

{{< highlight xml >}}

 BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

barCodeBuilder.CodeText = "&$#@$#@#&";

barCodeBuilder.SymbologyType = Symbology.Pdf417;

barCodeBuilder.Pdf417CompactionMode = Pdf417CompactionMode.Text;

barCodeBuilder.Save(@"Pdf417_fixed2.png");

{{< /highlight >}}

**BARCODENET-36348 PDF417 coded Barcode recognition is not working**

{{< highlight xml >}}

 string filename = @"barcode_pdf417.tif";

BarCodeReader reader = new BarCodeReader(filename, DecodeType.Pdf417);

int counter = 0;

while (reader.Read())

{

	counter++;

	byte[] bytes = reader.GetCodeBytes();

	Console.WriteLine(counter + " " +reader.GetCodeType() + " bytes: ");

	for (int i = 0; i < bytes.Length; i++)

	{

		if (i % 16 == 0 && i>0)

			Console.WriteLine();

		Console.Write(bytes[i].ToString("x2") + " ");

	}

	Console.WriteLine();

	Console.WriteLine();

}

reader.Close();

{{< /highlight >}}

Result:

1 Pdf417 bytes:

78 9c ed 7d 49 93 e4 36 92 ee 59 f5 2b c2 fa d2

dd f6 94 55 c4 c6 45 a6 8e b1 ac ad a5 96 6a 31

95 5a 7a 4f 97 31 66 04 33 83 aa 08 46 1a c9 a8

ed 87 bc d3 1c f5 1b de a9 6f f5 c7 1e b8 83 0c

80 74 44 70 cb 54 cd 4c f7 54 06 1d c0 07 a7 2f

80 c3 1d fc f6 bf 3e ec b6 8b 77 5e 18 f9 fb e0

1f 7f 45 0f 8d bf 2e bc 60 b5 5f fb c1 cd 3f fe

fa ef 9f 9f 5f d8 7f fd af e5 83 6f a3 e8 ed 37

3b 2f 8a dc 1b 6f b1 f3 83 7d f8 4b de e4 2f e8

2f 0b de 45 10 7d e3 ad 36 86 f5 8f bf 6c e2 f8

f6 9b 47 8f de bf 7f ff 90 ff f2 70 b5 79 94 3e

7e e4 3d f9 ee c2 30 0c eb e2 fa 91 29 36 b1 3b

9b d8 bc 09 11 9a 20 a3 ab 09 32 1a a3 20 d4 d9

04 f1 26 b6 d0 84 d2 ae 26 94 f2 26 54 6c 62 76

36 31 1b 73 71 3a 39 e6 58 8f 70 d1 80 bf 85 0e

72 84 9c aa 7f 37 ac 51 47 37 15 71 74 73 11 bb

1f d6 de 6a eb 86 6e cc 5f e4 85 1f 3f e2 dd 91

0b e3 51 f9 46 3f 44 7e ad 83 f7 e4 e1 3e bc 79

84 39 b7 1e fd ef 17 3f be 59 6d bc 9d 7b e1 07

51 ec 06 2b ef 2f cb 07 5f a5 72 b2 f1 dc b5 17

f2 bf b2 3f 57 6e 10 ef 83 67 1f 62 2f 48 24 26

f9 fd ab 6f dd 30 27 ab ff 9e 3e 88 f6 87 70 e5

bd f9 18 c5 de 2e fb 35 fb 39 fb e1 4d ec 1d bc

70 71 79 7b eb 05 9f bc ed 76 71 79 88 22 2f 0c

37 fb b5 17 7c fb a8 22 ac 5a e6 e2 bd e4 c0 8d

0b e3 21 ff df 94 ae f8 b9 22 0c bd ad e7 46 de

53 37 f6 72 62 c4 ff 2f 25 16 1f 55 0d 76 5c 51

ae fd 55 ca c1 bc 15 32 2f b8 c4 62 9a b6 3a 7a

9e 4d f2 91 74 96 49 87 eb fd ea b0 f3 82 f8 47

3f 8a 97 af 42 ff c6 0f dc ed 22 f0 57 9b 78 e1

1e a2 1b ef fa f3 7f b6 db d8 8b 16 19 1f bc f0

ed f6 f3 1f e1 21 b8 89 ae f7 e1 ee c0 5f 67 da

7b ad 1f 79 ef 3f ee 37 01 ef f2 bd e7 47 8b 5f

f6 61 e0 ee bc ff 7e 8d 16 2f 1f 7e bd b8 0d f7

8b cb f0 ca f3 e3 1b ef 8a 33 fb 6f bf f9 d7 d7

fc ff a3 bf 9f d5 39 ee a9 f3 c7 5e c4 45 cf 0f

fc 1b 3e ef c5 e7 ff 24 bd bc f1 e3 4f 09 17 2e

16 3f bb 37 37 de 96 8b d6 d7 0b 6e a4 de bb db

38 f9 9d 4b 79 b4 d9 73 c3 e5 86 de 82 03 7b 58

8d fb 90 80 47 be 3c 5c f3 f7 b5 dd 26 e3 7e 3a

2c 9e f9 c1 db cf ff 09 ae b9 08 27 6f 67 11 79

db ab 28 fe fc 47 b0 f6 6f 78 cf cf c2 f7 5e 98

fe 10 fb 37 6f f9 84 cb 31 f1 59 73 ad 86 4d 47

fd 61 bf dd 7a 6f 63 ff dd d7 fc 9f bb 9d cb 47

8f 2f 16 87 60 bd e0 ed ae 5d de 3c 58 fc d3 e3

d8 b6 bc 2b 37 05 5b e2 d0 98 3b 00 c9 4f 9c d6

0b 1e bd ce 34 5a 18 87 3c 84 cf f8 72 bb bd fe

fc c7 76 cb 59 b8 78 ec

2 Pdf417 bytes:

f9 5b ee 72 02 ce ec dd e2 57 2f 8c 39 84 d0 4f

a6 c0 95 f7 93 c7 d5 22 e0 02 f6 b7 a7 5e ec fa

5b ce 7f df db 78 9c ee 66 cb 99 cd 51 9e 36 b7

47 e2 5b ce e6 c9 e5 38 e6 ca 26 ce b7 98 9a 79

16 03 f9 04 e3 f0 f3 1f 7c aa 2e 17 a1 80 ab b3

1b 70 1e 2e 9e 73 65 e6 d3 e6 52 bc e0 5a c2 df

a5 97 b0 f3 4d 2a 5f ef f6 61 c4 ed 30 87 f0 e6

f3 1f 87 ad b7 20 ee df eb 1a 5c c9 36 79 78 9e

5a f5 8f 0f 37 f0 69 a9 42 a6 4a 09 3c 6e 07 c3

c5 0f 3e 1f 98 9b 92 38 f4 0e 89 92 bf dd 47 89

74 73 db c2 81 e7 3f 2e d6 dc ce 6e 16 4f 43 9f

3b 32 6e f1 f7 95 54 22 f3 21 3b 63 f4 7f 73 46

84 1b 6e 5f a2 8b 8a 4d e9 93 df bd 35 37 32 c9

63 de e6 3f f1 27 ce b0 d7 f5 a1 31 7b 68 9d f5

62 7e e4 b6 33 88 32 35 cf d4 2e 75 67 9c 2e 71

06 a2 ea 19 27 da b7 6c 9c 4b de b5 bf 4d 5f 3f

1f 8b 8f 91 fc 99 30 f9 19 b7 6c 4d 73 c2 c7 82

33 54 1c 2b 91 a3 cb c4 84 f1 ce 6e bc dd e7 3f

22 ee e0 56 9b 2d 77 ed 57 dc 02 04 9f aa 21 b0

8e 29 39 9a ce da f7 16 31 77 05 9f ff e0 bd fb

a9 69 7c cc 39 76 5d 88 4e 43 4c 9f e7 3e 75 41

bf 5e e4 00 e8 7d 1b ff 87 4a 69 0e 41 c3 83 bd

4c a4 cc 3b 72 63 0d 63 23 41 69 cd 09 a5 92 97

6a 94 e9 af b2 15 aa b0 a4 5d 5e fe f4 ed 23 e1

cf 64 c1 fb 48 b1 e2 4d 9b c5 a1 1b 44 ee ea 78

b1 c8 7e 36 9c 6f 90 f9 0d 17 6e 13 9b ff cb c0

df 18 46 d6 55 b3 49 d9 95 fb 81 5b 14 7f bf 4e

3b c9 69 cb df 0a aa db f4 cf e7 e1 7e 97 8f 95

2d 67 1b 8f ea d4 3f ef 33 5a 84 2f 48 8d 96 3f

78 d0 39 ff e4 cf 6c 65 bb cc 67 90 ff 55 7f f8

94 5b b4 d0 bf 4d a6 d5 b5 a0 97 37 7a 90 b3 ba

dc 6b 64 b8 f6 89 21 8c cb c1 76 ae 1f 24 af bd

7a 73 99 07 e0 ac 74 5f bb 61 cc 85 06 e5 42 99

3e cc 7e ca 4c f5 f7 7c f4 b8 5c bc 17 6b fe 84

6c 7f cd 7f f5 dd ed 4b 2e 5c cb 97 99 1e 64 68

6a 4f 84 16 d7 3e 77 04 e9 8f 95 e6 64 2d aa 27

02 f9 9a bf e9 57 d7 8f fd 30 de e4 3f 7f f5 6d

ba 23 fd e6 a3 e7 86 2f f8 24 37 4f dd 8f 4b e4

58 e5 0e 45 f2 38 ef f0 91 bc c7 74 a0 77 c1 d2

62 26 c2 84 32 d3 b2 1d 2b 23 7e 57 9f 6d bc a9

58 d2 80 73 9b ff fc 84 77 7f b3 0f 3f 2e 5f fc

fb 21 df 36 19 0f 6f fd 75 81 e9 88 46 de c5 d2

c8 61 98 cd 86 b5 89 48 d0 e4 32 da f5 ee d2 c9

b8 eb 75 e8 45 d1 f7 41 b2 59 aa bd d8 74 fb fe

cd 2d b7 32 ee f6 32 a3 12 91 22 43 dd b6 49 f1

a3 1f 78 68 f9 03 df 2d 86 7c 51 14 71 15 e6 f2

bc c0 e9 bc 9a 54 8d 1e e2 fd fb 60 f9 1d 57 b7

c8 3d 14 f4 e9 6f 0d ba

3 Pdf417 bytes:

e8 bd 1f 45 bf f9 b7 4f b8 8e 2c 1d 94 58 0b c9

83 02 ff a3 8e 09 64 1c 97 ce 3e 63 ae aa a5 72

7f 9f 59 f9 63 65 6b 52 a5 64 7e f4 6c 77 bb dd

7f f4 d6 cb 38 3c 78 a9 e9 15 7e ab 51 f2 15 e6

b5 27 a1 ae fd 5e 6b f1 72 1f fc ba 0f df fa c1

cd f2 da dd 46 45 03 e1 e7 82 09 20 c4 ed f6 af

c5 03 94 26 89 2f 44 dd ed 1b ee de 0e d1 cf ee

07 41 fe 10 aa 3f 5d e6 22 d3 fc 59 18 47 de 5b

3a 50 e8 f1 1d 54 32 36 c2 b9 ad 29 7f a9 88 7e

df 5f 2d d3 f5 47 69 90 92 5f aa e7 39 4b c3 65

b6 b3 fa ed 10 b9 f1 a7 ab 2d f7 b1 7c 6d 9b 35

28 49 44 3b fa 31 71 a6 f9 36 30 7f 4d 92 07 55

0b ee ba 5e 1c 02 6e 3b 6f dd ad 1f 7f 14 98 62

58 df ec 84 27 a9 a9 14 15 44 f6 5c 60 90 ac e3

d2 a9 c9 3c 81 dc 4b 60 71 76 2d ee 21 b3 5c 12

07 81 0b ab 26 73 11 d9 13 89 93 28 5b 1d b9 89

ec 67 5d 47 81 5b 1d 85 a2 4f 91 5d 4a c3 aa 61

04 f0 9d 33 02 47 88 cf 35 02 95 6e 22 90 6e e2

69 74 53 a1 28 58 58 08 6f fc ed 3a 79 74 ba 7e

dc 86 c9 ee 76 bf df 2e fe 86 e8 e2 5f ee 26 f4

fe ae a3 2c 49 0c 60 61 f4 a3 28 d8 30 30 60 45

35 8c a2 94 bc 94 ea c7 6a bf bb 3d 6c 23 be 80

7a b6 3e e4 bd 1a 59 1c 5b f6 48 10 67 65 bf a7

4b 71 fe a4 f6 f2 87 90 07 76 aa 3c a0 de e4 21

b1 9a 5f e4 61 26 f2 60 9e 2a 0f 3d 39 d2 ec 4c

88 7c 91 87 09 e5 81 6f 9b 8a 59 9c e3 31 48 9f

1e 83 de 19 89 40 f7 5e 22 4e f6 19 b4 4f 9f c1

be 48 c4 6c 24 e2 64 af c1 fa f4 1a e6 17 89 38

55 22 d6 7c b7 7f b5 f5 d6 59 70 ef cd e1 f6 76

1f c6 a0 d9 4b 5b 4a 39 b1 16 23 d2 fb 4f 5c 3c

dc ab 4f 87 9b 45 e6 42 d7 b5 d0 73 c9 04 50 f7

e7 6e 16 a3 ac db cb dd fe 10 c4 4b c4 0c 96 6f

07 eb 0f 2a 0e aa d9 35 39 37 d1 cc b8 89 a9 8d

8d 3b cb 4d 3c 33 6e 12 c7 70 c8 9d e5 26 99 19

37 29 36 a8 73 67 b9 49 67 c6 4d 46 ac 33 35 3d

f4 de 79 c1 c1 13 46 28 62 8d 2f 5c 3f f8 49 7c

5a 3b 4e cc c6 41 4b 8c 2c 1b 5b b5 d3 aa e2 91

aa 11 e6 8d 1c 0b 33 49 23 2c 32 41 09 a4 06 f3

8d bf f6 b6 7c 69 04 80 8a 11 2d 4e 95 35 a0 62

52 84 33 bb a1 4a c1 e4 6b bd f4 4d a2 fa 01 6d

7e 7e 97 76 f8 3c 49 8a 5c 22 cb 20 96 9d 1f 50

09 bf d7 56 4d b2 ae 64 a3 60 e5 28 84 da 8e a1

33 0a 06 69 58 2e 4d 52 9d 92 bc ce 2c c3 ed b5

70 60 58 d1 85 cb 17 1f 17 09 ed e2 f1 3e 8a f2

15 4b 3d f4 5b 1f 74 89 6c 8c cd 3c ad 55 94 85

af c4 a6 6d c3 9f 8f 12 77 a3 24 06 b1 ed 69 51

92 6e 94 94 58 0e 9d 16 25 ed 46 c9 1c 6a 1a d3

a2 64 dd 28 4d e6 30 67

4 Pdf417 bytes:

38 94 58 85 f2 b1 97 9c 99 7c e7 6e af 35 f5 88

d9 0c 9f 80 17 0f 81 17 a2 51 28 75 26 f3 c0 0b

d1 2d 93 92 53 e4 61 10 bc 10 2d 33 b1 39 1b fe

42 f4 cd a1 f4 14 db 25 c5 db f0 e8 52 cb 20 ae

07 b9 71 48 9a 88 ca 76 bc 5c 6c e8 1b 81 f0 b7

03 48 6f 98 55 db af 86 ce 51 1b cd 07 b3 6a 93

d3 d0 3b 87 d0 6e bb 36 16 66 d5 56 a2 a1 7b 16

63 dd 1e 6e 2c cc 0c 84 d9 34 21 fa 77 36 66 dc

82 59 30 1d da da c8 30 3e 15 bd 86 05 d1 46 0f

d4 4b 83 e0 53 e5 65 48 f4 40 0d 25 04 e0 c9 c7

47 0f d4 55 8a 08 9a 21 7a a0 d6 3a e9 3e b7 3f

f4 af 92 a4 d6 fa ae 5c 19 42 60 4c b6 c5 46 2d

cd d2 9d b9 89 1c f5 ce bc 81 5c 06 47 05 17 62

15 5f 78 5e ec 07 ea 50 7a c3 aa 50 0e b6 93 bb

6d 18 fa c0 0a b4 21 a6 cd ba 2d e0 d0 58 a1 3e

9d ff cf e4 58 a1 f6 c1 02 ac 99 86 c6 0a b4 06

7c 4f d5 bd 56 3a 03 2b d0 8a 69 6a 19 a6 00 ef

d7 86 a6 5f d4 40 7d 73 2c 34 27 d4 40 cd 63 cc

21 33 42 0d d4 41 c3 99 15 6a a0 36 12 c7 38 1f

75 24 24 12 bf 0a bc 17 6e f0 64 bf bb 75 83 8f

20 27 6d 60 62 63 7d 27 6d 30 cb a0 9d 4e 1a 0a

0d 32 0d 88 31 7c 76 b3 5f e4 ad 3a 4c 4b 02 3a

4d b4 4f 9e bc ba ce a3 e1 55 7e b6 e2 b9 d4 3a

25 55 49 ca b7 a8 3b ad 21 58 d1 6e af 7a 64 05

41 84 a8 05 7a 0e ac 68 37 82 8a a9 56 59 f8 1a

bc a0 06 75 d4 cb 82 39 f0 a2 dd b4 f6 28 16 0c

93 96 c8 c1 1c 58 d1 6e af fb 14 0b d3 30 a9 7a

65 3b 20 2f 80 1e 6c 1a 13 6a 3b 2d c1 19 dd 09

0e cb 94 f1 8c a9 61 a3 b3 8d e9 48 4c 19 d1 ac

22 62 9e ad 3f 23 71 65 3c 03 4b f9 02 f8 8e 30

65 4c 53 6b d8 c3 71 45 6b 91 6d 9a 48 96 17 d3

bd c8 2e 52 d4 80 8b 6c d8 f2 5a df 57 8e ef 11

a8 83 d4 49 1f f0 c9 f4 37 f5 f1 ec 3e 31 c9 bc

a6 3e a2 75 37 ed 96 98 c9 14 73 1f cf 86 23 83

c0 f6 0b 63 4d 7d 4c 4b 8d 91 3a 79 aa e7 b9 03

7d d6 f8 26 0f 59 c0 38 c2 39 8e ea 34 26 8c b8

e8 75 5a 92 94 a6 65 c2 88 66 d0 26 f4 0c 7d 18

94 0b 63 2e 6a 5b b2 00 a7 65 c2 98 a6 11 59 7d

29 44 91 fb 9b 3f ab a7 2c 4b 5d 41 7a 59 5f 87

09 cc 12 8d 91 61 2c 91 c5 f7 ac 29 6d f5 5b 8d

2f 5e b8 e2 1d ba 37 de d2 ce fa 14 7e 39 ee b2

c8 69 b6 a9 29 74 2a 64 34 7f 55 5c 81 d1 36 ad

73 26 de 6e f6 aa 49 12 03 e5 a9 5e 3d 4e 1c f3

ad 2e 9e 68 e2 ed a6 ae 9a 24 25 16 33 fb 9e 38

61 86 41 27 9a 78 bb 75 ab 26 c9 ec e2 20 b5 c7

89 53 d3 b1 ac 89 26 de 6e d1 aa 49 9a c4 c0 b4

ef 89 33 83 22 67 88 89 03 cd ba a6 99 33 d3 22

0b 08 0b 4c b8 99 33 10

**BARCODENET-36347 Improve recognition rotated MicroQr barcodes** 
Code sample:

{{< highlight xml >}}

 string filename = @"Micro_QR_Example_rotated.png";

BarCodeReader reader = new BarCodeReader(filename, DecodeType.MicroQR);

while (reader.Read())

{

    Console.WriteLine("-- Symbol: " + reader.GetCodeType() + " Code: " + reader.GetCodeText());

}

reader.Close();

{{< /highlight >}}

Result:

{{< highlight xml >}}

 -- Symbol: MicroQR Code:

{{< /highlight >}}
