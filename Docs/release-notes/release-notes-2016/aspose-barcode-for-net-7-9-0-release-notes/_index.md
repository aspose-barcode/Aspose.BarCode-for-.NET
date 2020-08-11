---
title: Aspose.BarCode for .NET 7.9.0 Release Notes
type: docs
weight: 90
url: /net/aspose-barcode-for-net-7-9-0-release-notes/
---

### **Features and Improvements**

|**Key** |**Summary** |**Category** |
| :- | :- | :- |
|BARCODENET-34430 |Implement new algorithm to recognize 3D-distorted Aztec codes |New Feature |
|BARCODENET-34421 |Generate data matrix barcode with text on its right side |New Feature |
|BARCODENET-34433 |Not able to recognize rectangular Aztec codes |Enhancement |
|BARCODENET-34422 |Verify APTCACheck for Aspose.Barcode DLL |Enhancement |
|BARCODENET-34410 |Unable to Read the QR barcode successfully from a PDF file |Enhancement |
|BARCODENET-34398 |Unable to Read the QR barcode successfully from a TIFF image |Enhancement |
|BARCODENET-34390 |Unable to read QR barcode from a BMP image |Enhancement |
### **Public API and Backward Incompatible Changes**
###### **BARCODENET-34421 Generate data matrix barcode with text on its right side**
***1)*** New Code location value **CodeLocation.Right** has been added to the enumeration: ***CodeLocation;***

***2)*** New property **Display2DText** has been added to the **BarCodeBuilder** class;

Code sample

{{< highlight xml >}}

 BarCodeBuilder builder = new BarCodeBuilder(

@"GTIN:898978777776665655

  UID: 121212121212121212

  Batch:GH768

  Exp.Date:150923", Symbology.DataMatrix);

builder.CodeLocation = CodeLocation.Right;

builder.Margins = new MarginsF(0,0,0,0);

//builder.CodeTextSpace = 0; // not recommended small space

builder.Save("codetextRight.png");


{{< /highlight >}}

In order to avoid including all the names into the codetext, the property called "*Display2DText*" should be used.
See the sample below.

Code sample:

{{< highlight xml >}}

 string gtin = "898978777776665655";

string uid = "121212121212121212";

string batch = "GH768";

string expDate = "150923";

string textToEncode = gtin + uid + batch + expDate; // or  "(01)"+ gtin + "(..)"+ uid + ...

string textToDisplay = "GTIN:" + gtin + "\nUID:" + uid + "\nBatch:" + batch + "\nExp.Date:" + expDate;

BarCodeBuilder builder = new BarCodeBuilder(textToEncode, Symbology.DataMatrix);

builder.Display2DText = textToDisplay;

builder.CodeLocation = CodeLocation.Right;

builder.Margins = new MarginsF(0,0,0,0);

//builder.CodeTextSpace = 0; // not recommended small space

builder.Save("codetextRightDisplay.png");

{{< /highlight >}}
