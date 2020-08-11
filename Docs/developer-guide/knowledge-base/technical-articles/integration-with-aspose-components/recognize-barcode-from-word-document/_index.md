---
title: Recognize Barcode from Word Document
type: docs
weight: 40
url: /net/recognize-barcode-from-word-document/
---

## **Recognize Barcode from Word Document**
In this article, we will recognize the barcode from a Word document using [Aspose.BarCode](http://www.aspose.com/categories/.net-components/aspose.barcode-for-.net/default.aspx) and [Aspose.Words](http://www.aspose.com/categories/.net-components/aspose.words-for-.net/default.aspx). We will follow the below steps for reading barcode from the Word document:

1. Extract image from Word document using Aspose.Words for .NET.
1. Save the extracted image as a stream.
1. Pass the image in the form of the stream to Aspose.BarCode for .NET.
1. Read the barcode from the image.

Use Aspose.Words.Document class to open the Word document. Call Document.GetChildNodes() method to get a collection of all the shapes (including images) in the Word document. In a for each loop on the collection, check if the shape has an image using Shape.HasImage property and called Shape.ImageData.Save() method and save the image to stream. Initialize Aspose.BarCodeRecognition.BarCodeReader class with the stream and DecodeType and then call BarCodeReader.Read() method to read the barcodes from the stream (image). The sample code snippet is given below:
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-TechnicalArticles-RecognizeBarcodeFromWordDocument-RecognizeBarcodeFromWordDocument.cs" >}}



The evaluation version of Aspose.BarCode for .NET can only recognize Code39 barcodes. If the image contains a barcode of other than Code39 symbology type, a valid license must be set. For getting a temporary license for 30 days, please visit <http://www.aspose.com/corporate/purchase/temporary-license.aspx> for more details.
