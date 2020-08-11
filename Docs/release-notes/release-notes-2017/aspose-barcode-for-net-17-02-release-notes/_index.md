---
title: Aspose.BarCode for .NET 17.02 Release Notes
type: docs
weight: 110
url: /net/aspose-barcode-for-net-17-02-release-notes/
---

Aspose.BarCode for .Net has been updated to version 17.02 and we are pleased to announce it.
The following is a list of changes in this version of Aspose.Imaging.
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-36457|[Unable to successfully read code39standard barcode from PNG image](https://www.aspose.com/community/forums/thread/820819/code39standard-barcode-is-not-recognized.aspx)|Enhancement|
|BARCODENET-36456|[QR code is not recognizing](https://www.aspose.com/community/forums/thread/820069/aspose-barcode-reader-for-qr-code-appears-to-be-not-working-for-the-attached-document.aspx)|Enhancement|
|BARCODENET-36450|Restore code128 uses a bitmap spliting in the histogram algorithm|Enhancement|
# **Usage examples**
**BARCODENET-36457 Unable to successfully read code39standard barcode from PNG image**

Sample:

{{< highlight java >}}

 using (BarCodeReader reader = new BarCodeReader("bar.png", DecodeType.AllSupportedTypes))

{

    reader.RecognitionMode = RecognitionMode.MaxBarCodes;

    while (reader.Read())

    {

        Console.WriteLine("{0}: {1}", reader.GetCodeType(), reader.GetCodeText());

    }

}

{{< /highlight >}}

Result:

{{< highlight java >}}

 Code39Standard: 16-23285

{{< /highlight >}}

**BARCODENET-36456 QR code is not recognizing**

Sample:

{{< highlight java >}}

 string filename = "image1_out.png";

using (BarCodeReader reader = new BarCodeReader(filename, DecodeType.QR))

{

    reader.RecognitionMode = RecognitionMode.MaxQuality;

    while (reader.Read())

    {

        Console.WriteLine(reader.GetBarCodeDecodeType() + ": " + reader.GetCodeText());

    }

}

{{< /highlight >}}

Result:

{{< highlight java >}}

 QR: B8BFFEE8-75C2-47EA-AF95-A608BF574771-201701-1501761-29238569-18259579-8929-1988-07-26

{{< /highlight >}}

**BARCODENET-36450 Restore code128 uses a bitmap spliting in the histogram algorithm**

Code sample

{{< highlight java >}}

 string filename = @"42.tif";

using(BarCodeReader barcodeReader = new BarCodeReader(filename, DecodeType.Code128))

{

   barcodeReader.RecognitionMode = RecognitionMode.MaxQuality;

   while (barcodeReader.Read())

   {

      Console.WriteLine(" -- Symbol:" + barcodeReader.GetCodeType() + " Code :" + barcodeReader.GetCodeText());

   }

}

{{< /highlight >}}

{{< highlight java >}}

 Result:

 -- Symbol:Code128 Code :AZ000000014942

{{< /highlight >}}
