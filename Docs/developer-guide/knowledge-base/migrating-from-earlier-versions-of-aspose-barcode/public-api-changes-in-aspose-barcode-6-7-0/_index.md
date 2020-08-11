---
title: Public API Changes in Aspose.BarCode 6.7.0
type: docs
weight: 30
url: /net/public-api-changes-in-aspose-barcode-6-7-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.BarCode API from version 6.6.0 to 6.7.0, that may be of interest to module/application developers. It includes not only new and updated public methods, but also a description of any changes in the behavior behind the scenes in Aspose.BarCode. 

{{% /alert %}} 
### **Property Symbology.PatchCode is added**
We’ve added encoding support of Patch code symbology, whereas decoding capability is already present.

{{< highlight java >}}

 BarCodeBuilder builder = new BarCodeBuilder("Patch T", Symbology.PatchCode);

builder.Save("PatchCode.png");

{{< /highlight >}}
### **Property RecognitionHints.ImageBinarizationHints.LineCodesRestoration is added**
We’ve added a new Line Codes Restoration filter. This filter restores corrupted strokes for 1D barcodes. This degradation could come from dirty, dusty products or discarded barcode resulting in touched or missing parts of the bars.

{{< highlight java >}}

 // Create an instance of BarCodeReader and set image and symbology type to recognize

BarCodeReader reader = new BarCodeReader(@"c:\temp\MyBarcode.png", BarCodeReadType.Code39Standard);

// Set grayscale image processing

reader.ImageBinarizationHints = RecognitionHints.ImageBinarization.LineCodesRestoration;

// Try to recognize all possible barcodes in the image

while (reader.Read())

{

    // Display the codetext

    Console.WriteLine("Codetext: " + reader.GetCodeText());

}

// Close the reader

reader.Close();

{{< /highlight >}}
### **Property License.IsLicensed is added**
We have added IsLicensed property in the License class. It helps to check the current status of the License that whether it is applied or not.

{{< highlight java >}}

 //Instantiate an instance of license and set the license file through its path

Aspose.BarCode.License license = new Aspose.BarCode.License();

//check license status

Console.WriteLine(license.IsLicensed); // returns false

//apply status

license.SetLicense("Aspose.BarCode.lic");

//check license status

Console.WriteLine(license.IsLicensed);  // returns true

{{< /highlight >}}
### **Property RecognitionHints.ImageBinarization.Grayscale is removed**
We’ve removed GrayScale filter.
