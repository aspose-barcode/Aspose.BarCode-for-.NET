---
title: Aspose.BarCode for .NET 8.1.0 Release Notes
type: docs
weight: 70
url: /net/aspose-barcode-for-net-8-1-0-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.BarCode for .NET 8.1.0](http://www.aspose.com/downloads/barcode/net/new-releases/aspose.barcode-for-.net-8.1.0/)

{{% /alert %}} 
### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|BARCODENET-36239 |Support saving to CMYK format |New Feature |
|BARCODENET-34430 |Support new algorithm for recognizing 3D-distorted Aztec codes |New Feature |
|BARCODENET-36252 |Fake recognition of 2D barcodes with many errors |Enhancement |
|BARCODENET-36248 |Improve recognition speed for Aztec |Enhancement |
|BARCODENET-36240 |Add support to read barcode in CMYK |Enhancement |
|BARCODENET-36232 |Databar Expanded barcode is generated incorrectly for the big length (21 or 22 symbols) |Enhancement |
|BARCODENET-36231 |Add error correction for Mode Message in Aztec code |Enhancement |
|BARCODENET-36230 |Correction of moot symbols in a Databar Expanded barcode |Enhancement |
|BARCODENET-36229 |Recognize a datamtrix with black dots around |Enhancement |
|BARCODENET-36228 |Fix order of recognition results for Aztec |Enhancement |
|BARCODENET-36223 |Unable to recognize the barcode from PDF |Enhancement |
|BARCODENET-36211 |Recognize datamatrix with a lot of errors because of low scanner resolution |Enhancement |
|BARCODENET-36195 |Program hangs on Aztec code |Enhancement |
|BARCODENET-34304 |QREncodeMode Enumeration is missing Binary enum |Enhancement |
|BARCODENET-36214 |BarCodeWebControl Error in VS2013 community |Enhancement |
|BARCODENET-36200 |Load Barcode controls in the toolbox of VS2013 shows Error |Enhancement |
### **Public API and Backward Incompatible Changes**
###### **BARCODENET-36239 Implement saving to CMYK format**
New public method SaveAsTiffInCMYK() has been added to the BarCodeBuilder.

Sample code:

{{< highlight java >}}

 BarCodeBuilder barcode = new BarCodeBuilder("1234567890", Symbology.Code39Standard);

barcode.SaveAsTiffInCMYK("code39Standard_in_cmyk.tiff");

{{< /highlight >}}

Sample code with parameters:

{{< highlight java >}}

 BarCodeBuilder barcode = new BarCodeBuilder("1234567890", Symbology.QR);

barcode.Resolution.DpiX = 200;

barcode.ForeColor = Color.Blue;

barcode.CodeTextColor = Color.Red;

barcode.BackColor = Color.LightPink;

barcode.SaveAsTiffInCMYK("qr_in_cmyk.tiff");

{{< /highlight >}}
