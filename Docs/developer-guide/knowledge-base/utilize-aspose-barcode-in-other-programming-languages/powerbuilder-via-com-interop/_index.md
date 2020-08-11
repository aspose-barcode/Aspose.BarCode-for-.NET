---
title: PowerBuilder via COM Interop
type: docs
weight: 60
url: /net/powerbuilder-via-com-interop/
---

## **Installation and Configuration**
PowerBuilder binaries are available from [http://www.sybase.com](http://www.sybase.com/). Please download and install the latest version of PowerBuilder for your version of Windows Operating System.
## **PowerBuilder Code to Generate BarCode**
The sample code below generates a barcode of type Pdf417 and will save the barcode image in a folder in hard disk.
#### **PowerBuilder**
{{< highlight java >}}

 // Create an ole object

oleobject barcode;

barcode = CREATE oleobject;

// Initialize it with BarCodeBuilder

barcode.ConnectToNewObject("Aspose.BarCode.BarCodeBuilder");



// Set the code text, symbology type and save the barcode image

barcode.CodeText = "test-123";

barcode.SymbologyType = 15;

barcode.Save("testpowerbuilder_out.png");

{{< /highlight >}}



Please note that the above code sample uses constant value 4096 for Symbology type which is for Pdf417.
