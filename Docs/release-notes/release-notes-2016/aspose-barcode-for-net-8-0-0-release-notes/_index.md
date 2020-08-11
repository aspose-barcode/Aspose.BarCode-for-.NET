---
title: Aspose.BarCode for .NET 8.0.0 Release Notes
type: docs
weight: 80
url: /net/aspose-barcode-for-net-8-0-0-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.BarCode for .NET 8.0.0](http://www.aspose.com/downloads/barcode/net/new-releases/aspose.barcode-for-.net-8.0.0/)

{{% /alert %}} 
### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|BARCODENET-34365 |Add new BarCode type: DutchKix |New Feature |
|BARCODENET-34361 |Add new BarCode type: DotCode |New Feature |
|BARCODENET-36213 |Barcode not recognized if image is not rotated |Enhancement |
|BARCODENET-36212 |Unable to Read the barcode from a PNG image having 100 multiple barcodes in it |Enhancement |
|BARCODENET-36210 |BarCodeReader not detecting the barcodes with default settings |Enhancement |
|BARCODENET-36208 |Support recognition of invasion in the quiet zone for data matrix |Enhancement |
|BARCODENET-36205 |Incorrect 3D-distorted Aztec code recognition |Enhancement |
|BARCODENET-36201 |Incorrect recognition of the Aztec code |Enhancement |
|BARCODENET-36196 |Recognize poor quality code128 with histogram method |Enhancement |
|BARCODENET-36195 |Program hangs on Aztec code |Enhancement |
|BARCODENET-36188 |Can't recognize 3D-distorted Aztec code from the JPG image |Enhancement |
|BARCODENET-36186 |Several consecutive recognitions give different results |Enhancement |
|BARCODENET-36182 |Rows does not work for PDF417 barcode |Enhancement |
|BARCODENET-36175 |Investigate and fix order of recognizing barcodes |Enhancement |
|BARCODENET-36172 |Improve dotcode regions recognition |Enhancement |
|BARCODENET-34428 |Read the corrupted QR barcode |Enhancement |
### **Public API and Backward Incompatible Changes**
###### **BARCODENET-34365 Add new BarCode type: DutchKix**
Support for new symbology DutchKIX has been added to the BarCode API.
<example>
Code sample (Encoder)

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder(@"258369AA", Symbology.DutchKIX);

builder.Save("DutchKIX.png");

{{< /highlight >}}

Code sample (Decoder)

{{< highlight xml >}}

 using (BarCodeReader reader = new BarCodeReader("DutchKIX.png", DecodeType.DutchKIX))

{

    while (reader.Read())

    {

       Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());

    }

}


{{< /highlight >}}

Result:

{{< highlight xml >}}

 DutchKIX: 258369AA

{{< /highlight >}}
###### **BARCODENET-34361 Add new BarCode type: DotCode**
Support for new symbology DotCode has been added to the BarCode API.

<example>
Encoder code sample

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder(@"!AA-11;", Symbology.DotCode);

builder.Save("DotCode.png");

{{< /highlight >}}

Decoder code sample

{{< highlight xml >}}

 string filename = "DotCode.png";

using (BarCodeReader reader = new BarCodeReader(filename, DecodeType.DotCode))

{

	while (reader.Read())

	{

		Console.WriteLine(reader.GetCodeType() + ": " + reader.GetCodeText());

	}

}

{{< /highlight >}}

Result:

{{< highlight xml >}}

 DotCode: !AA-11;

{{< /highlight >}}

</example>
