---
title: Aspose.BarCode for .NET 8.2.1 Release Notes
type: docs
weight: 50
url: /net/aspose-barcode-for-net-8-2-1-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for Aspose.BarCode for .NET 8.2.1.

{{% /alert %}} 
### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|BARCODENET-36302 |[Aspose.Barcode is returning unwanted barcodes when try to read barcode from image](http://www.aspose.com/community/forums/thread/597692.aspx)|Enhancement |
|BARCODENET-36310 |[Aspose.BarCode is not recognizing correct DataMatix coded barcode](http://www.aspose.com/community/forums/page_2/769721/showthread.aspx)|Enhancement |
|BARCODENET-36316 |Exclude unwanted code128 |Enhancement |
# **Usage examples:**
**BARCODENET-36302 Aspose.Barcode is returning unwanted barcodes when try to read barcode from image** 
Code sample

{{< highlight xml >}}

 BarCodeReader reader = new BarCodeReader(@"00000010_00000003_2.tif");

int counter = 0;

while (reader.Read())

{

	counter++;

	Console.WriteLine(" -- Symbol:" + reader.GetCodeType() + " Code :" + reader.GetCodeText());

}

reader.Close();

Console.WriteLine(counter.ToString());

{{< /highlight >}}

Result:

{{< highlight xml >}}

 Symbol:DataMatrix Code :AZ000000199139

{{< /highlight >}}

**BARCODENET-36310 Aspose.BarCode is not recognizing correct DataMatix coded barcode** 
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
