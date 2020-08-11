---
title: FAQs
type: docs
weight: 50
url: /net/faqs/
---

Q: Why can I see "Aspose" on the barcode I've generated?

**A**: You're using an evaluation version of the component. The [evaluation version](http://www.aspose.com/docs/display/barcodenet/Licensing#Licensing-EvaluationVersionLimitations) of Aspose.BarCode puts "Aspose" on the barcode image. To remove the word, [apply a license](http://www.aspose.com/docs/display/barcodenet/Licensing#Licensing-SettingaLicenseinAspose.BarCodefor.NET).

Q: Does Aspose.BarCode automatically calculate the check digit?

**A**: Yes, the Aspose.BarCode.BarCodeBuilder class automatically calculates the check digit and adds it to the generated barcode symbol.

Q: Does Aspose.BarCode support Enhanced MetaFile format?

**A**: Aspose.BarCode can save generated barcode labels to Enhanced MetaFile (EMF) format. THe Aspose.BarCode.BarCodeBuilder class has the SaveAsEmf method just for this purpose.

Q: Why am I getting the InvalidCodeException when generating 2D barcode symbols?

**A**: *InvalidCodeException* indicates that the code text to be encoded, exceeds the maximum size limit for the specified 2D barcode type.
