---
title: Aspose.BarCode for .NET 17.5 Release Notes
type: docs
weight: 80
url: /net/aspose-barcode-for-net-17-5-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for Aspose.BarCode for .NET 17.5

{{% /alert %}} 
### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|BARCODENET-36531|Add support for generate DataMatrix with Text encodation scheme|Feature|
|BARCODENET-36525|Add support for generate DataMatrix with C40 encodation scheme|Feature|
|BARCODENET-36557|Unable to get the supplement code text from EAN13 coded barcode (supplement barcode is bit blurred)|Enhancement|
|BARCODENET-36547|Aspose.BarCode is not producing correct output after reading UPCA barcode|Enhancement|
|BARCODENET-36546|Different recognition result with DecodeType.AllSupportedTypes and BarCodeReadType.AllSupportedTypes|Enhancement|
|BARCODENET-36536|Aspose.BarCode is unable to extract barcode from PDF|Enhancement|
|BARCODENET-36516|Aspose Barcode is not reading DataMatrix coded barcode correctly|Enhancement|
### **Public API and Backward Incompatible Changes**
This section lists public API changes that were introduced in Aspose.BarCode for .NET 17.5. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.BarCode for .NET which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.
##### **New public value Text has been added to the DataMatrixEncodeMode enum. It allows to generate DataMatrix with Text encodation scheme.**
BARCODENET-36531 Add support for generate DataMatrix with Text encodation scheme

Code sample:

{{< highlight java >}}

 using(BarCodeBuilder buidler = new BarCodeBuilder("abcdef123456", EncodeTypes.DataMatrix))

{

  buidler.DataMatrixEncodeMode = DataMatrixEncodeMode.Text;

  buidler.Save("dataMatrixText.png");

}

{{< /highlight >}}

Result:

picture "dataMatrixText.png".
##### **New public value C40 has been added to the DataMatrixEncodeMode enum. It allows to generate DataMatrix with C40 encodation scheme.**
BARCODENET-36525 Add support for generate DataMatrix with C40 encodation scheme

Code sample:

{{< highlight java >}}

 using(BarCodeBuilder buidler = new BarCodeBuilder("ABCDEF123456", EncodeTypes.DataMatrix))

{

  buidler.DataMatrixEncodeMode = DataMatrixEncodeMode.C40;

  buidler.Save("dataMatrixC40.png");

}

{{< /highlight >}}

Result:

picture "dataMatrixC40.png".
