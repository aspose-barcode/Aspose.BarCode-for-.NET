---
title: Aspose.BarCode for .NET 7.8.0 Release Notes
type: docs
weight: 100
url: /net/aspose-barcode-for-net-7-8-0-release-notes/
---

### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|BARCODENET-34399 |Add a manual hint "SkipRotatedBarcodes" |New Feature |
|BARCODENET-34368 |Add new BarCode type: MICR (only reader) |New Feature |
|BARCODENET-34364 |Add new BarCode type: Datalogic2of5 |New Feature |
|BARCODENET-34363 |Add new BarCode type: Code32 |New Feature |
|BARCODENET-34415 |Unable to recognize PDF417 barcode |Enhancement |
|BARCODENET-34411 |System.OutOfMemoryException thrown for a specific PDF document |Enhancement |
|BARCODENET-34403 |Incorrect Path IV recognition |Enhancement |
|BARCODENET-34402 |Recognize DataMatrix barcode with small module and a blur |Enhancement |
|BARCODENET-34400 |Unable to read PDF417 barcode with a data length of 650 characters |Enhancement |
|BARCODENET-34397 |Support the API with more than 64 barcode types |Enhancement |
|BARCODENET-34386 |Can't recognize sample Aztec from specification |Enhancement |
|BARCODENET-34373 |Can't recognize Aztec with a lot of data |Enhancement |
|BARCODENET-33818 |Can't recognize DataMatrix code from a PNG image |Enhancement |
### **Public API and Backward Incompatible Changes**
###### **Enum BarCodeReadType has been marked as [OBSOLETE]**
Since enum ***BarCodeReadType*** allows us to support only first 62 symbologies, new type has been added, and it is highly recommended to use new type called ***DecodeType*** instead.

***BarCodeReadType*** will have been unavailable within two months term.
###### **New types have been added to support more BarCode types**
***DecodeType, BaseDecodeType, SingleDecodeType, MultyDecodeType***

These types will be further used in BarCodeReader instead of BarCodeReadType.

Create single decode type

{{< highlight xml >}}

 [C#]

SingleDecodeType singleType = DecodeType.QR

{{< /highlight >}}

{{< highlight xml >}}

 [VB.NET]

Dim singleType As SingleDecodeType

singleType = DecodeType.QR

{{< /highlight >}}

Creates compound MultyDecode types that combine SingleDecodeType and MultiDecode types.

{{< highlight xml >}}

 [C#]

MultyDecodeType types1 = new MultyDecodeType(DecodeType.QR, DecodeType.DataMatrix);

MultyDecodeType types2 = new MultyDecodeType(types1, DecodeType.Code128, DecodeType.Code39Standard);

{{< /highlight >}}

{{< highlight xml >}}

 [VB.NET]

Dim multyType1 As MultyDecodeType

multyType1 = New MultyDecodeType(DecodeType.QR, DecodeType.DataMatrix)

Dim multyType2 As MultyDecodeType

multyType2 = New MultyDecodeType(multyType1, DecodeType.Code128, DecodeType.Code39Standard)

{{< /highlight >}}
###### **Namespaces have been updated**
Public *Namespaces* have been re-arranged according to [Microsoft guidelines. ](https://msdn.microsoft.com/en-us/library/ms229026%28v=vs.110%29.aspx)

The namespace ***Aspose.BarCodeRecognition*** has been replaced with ***Aspose.BarCode.BarCodeRecognition; BarCode.Common*** has been replaces with ***Aspose.BarCode.Common.***

Thus, the namespaces ***Aspose.BarCodeRecognition,*** ***BarCode.Common*** are not available anymore.
###### **BARCODENET-34399 Add a manual hint "SkipRotatedBarcodes"**
New manual hint has been added to the available API: ***SkipRotatedBarcodes***

It turns off rotation algorithms, and  therefore, increases the recognition speed.
It is available only for Datamatrix and the linear barcodes.Code sample

{{< highlight xml >}}

 Stopwatch watch = new Stopwatch();

string filename = @"Datamatrix12.jpg";

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.GS1DataMatrix))

{

	Console.WriteLine("Skip rotated barcodes");

	watch.Start();

	reader.RecognitionMode = RecognitionMode.ManualHints;

	reader.ManualHints = ManualHint.SkipRotatedBarcodes;

	while (reader.Read())

	{

		Console.WriteLine(reader.GetReadType() + ": " + reader.GetCodeText() + " QA:" + reader.GetRecognitionQuality());

	}

	watch.Stop();

	Console.WriteLine("Time: " + watch.ElapsedMilliseconds + "ms.");

	Console.WriteLine();

}

using (BarCodeReader reader = new BarCodeReader(filename, BarCodeReadType.GS1DataMatrix))

{

	Console.WriteLine("Not skip rotated barcodes");

	watch = new Stopwatch();

	watch.Start();

	while (reader.Read())

	{

		Console.WriteLine(reader.GetReadType() + ": " + reader.GetCodeText() + " QA:" + reader.GetRecognitionQuality());

	}

	watch.Stop();

	Console.WriteLine("Time: " + watch.ElapsedMilliseconds + "ms.");

}


{{< /highlight >}}

Result:

{{< highlight xml >}}

 Skip rotated barcodes

DataMatrix: Wikipedia on erinomainen tietosanakirja, josta lГ¶ytyy paljon tietoa mm. viivakoodeista. QA:0

Time: 116ms.


Not skip rotated barcodes

DataMatrix: Wikipedia on erinomainen tietosanakirja, josta lГ¶ytyy paljon tietoa mm. viivakoodeista. QA:0

Time: 436ms.

{{< /highlight >}}
###### **BARCODENET-34368 Add new BarCode type: MICR (only reader)**
New barcode type **MICR** has been added*.*

It is available only as a feature of **BarCodeReader** class.Code sample

{{< highlight xml >}}

 using (BarCodeReader reader = new BarCodeReader("MICR.jpg", BarCodeReadType.MicrE13B))

{

	while (reader.Read())

	{

		Console.WriteLine(reader.GetReadType() + ": " + reader.GetCodeText());

	}

}




{{< /highlight >}}

Result:

{{< highlight xml >}}

 A011234567A001234567C243

{{< /highlight >}}
###### **BARCODENET-34364 Add new BarCode type: Datalogic2of5Code**
Code sample (Generate)

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder("8500060000", Symbology.DataLogic2of5);

            builder.Save("DataLogic2of5.png");

{{< /highlight >}}

Code sample (Recognize)

{{< highlight xml >}}

 using (BarCodeReader reader = new BarCodeReader("DataLogic2of5.png", DecodeType.DataLogic2of5))

{

    while (reader.Read())

    {

        Console.WriteLine(reader.GetDecodeType() + ": " + reader.GetCodeText());

    }

}


{{< /highlight >}}

Result:

{{< highlight xml >}}

 DataLogic2of5: 8500060000

{{< /highlight >}}
###### **BARCODENET-34363 Add new BarCode type: Code32**
New barcode type **Code32** has been added.Code sample (Generate)

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder("123456788", Symbology.Code32);

builder.Save("code32.png");

{{< /highlight >}}

Code sample (Recognize)

{{< highlight xml >}}

 using (BarCodeReader reader = new BarCodeReader("code32.png", BarCodeReadType.Code32))

{

	while (reader.Read())

	{

		Console.WriteLine(reader.GetReadType() + ": " + reader.GetCodeText());

	}

}


{{< /highlight >}}

Result:

{{< highlight xml >}}

  Code32: 123456788

{{< /highlight >}}
