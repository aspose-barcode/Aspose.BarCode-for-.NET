---
title: Aspose.BarCode for .NET 17.12 Release Notes
type: docs
weight: 10
url: /net/aspose-barcode-for-net-17-12-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for Aspose.BarCode for .NET 17.12

{{% /alert %}} 

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-36710|Support to set QR version while generating barcode image|Feature|
|BARCODENET-36279|Improve speed and quality of the new 1D recognition algorithm|Enhancement|
|BARCODENET-36740|Fake recognition of OneD barcodes|Bug|
|BARCODENET-36733|Setting License in Aspose.BarCode throws exception|Bug|
|BARCODENET-36726|Aspose.BarCode throw exception when used in multi threading|Bug|
|BARCODENET-36722|Setting License in Aspose.BarCode takes too long|Bug|
|BARCODENET-36690|Unable to recognize DatabarStacked barcode with big white space|Bug|
|BARCODENET-36689|Aspose.Barcode is unable to recognize Code128 barcode from JPG image|Bug|
|BARCODENET-36630|Unable to recognize barcode from a TIFF image|Bug|
|BARCODENET-36465|Datamatrix barcode is generated incorrectly|Bug|
|BARCODENET-34036|Performance issue while reading PDF417 and Code128 codes|Bug|
|BARCODENET-34035|Performance issue while reading PDF417 and Code128 codes|Bug|
|BARCODENET-34034|Performance issue while reading PDF417 and Code128 codes|Bug|
|BARCODENET-34033|Performance issue while reading PDF417 and Code128 codes|Bug|
|BARCODENET-36627|Performing BarCode recognition in C++ application is taking long time|Bug|
|BARCODENET-33832|Can't recognize code128 from a tif file|Bug|
### **Public API and Backward Incompatible Changes**
This section lists public API changes that were introduced in Aspose.BarCode for .NET 17.12. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.BarCode for .NET which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

**New public value QRVersion has been added to the BarCodeBuilder for selecting concrete QR version.**

BARCODENET-36710 Support to set QR version while generating barcode image

Code sample:

{{< highlight java >}}

 using (BarCodeBuilder builder = new BarCodeBuilder())

{

    builder.CodeText = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    builder.EncodeType = EncodeTypes.QR;

    builder.QRErrorLevel = QRErrorLevel.LevelQ;

    builder.QRVersion = QRVersion.Version10;

    builder.Save("qr_version10_errorQ.png");

}

{{< /highlight >}}
