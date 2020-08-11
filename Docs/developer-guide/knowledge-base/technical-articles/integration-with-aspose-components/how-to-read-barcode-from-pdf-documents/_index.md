---
title: How to Read Barcode from PDF Documents
type: docs
weight: 20
url: /net/how-to-read-barcode-from-pdf-documents/
---

## **Recognize Barcode from PDF Documents**
In this article, we will recognize the barcode from a pdf document using Aspose.BarCode for .NET and Aspose.PDF for .NET. We will follow the below steps for reading barcode from the PDF document:

1. Extract image from a pdf document using Aspose.PDF for .NET.
1. Save the extracted image as a stream.
1. Pass the image in the form of the stream to Aspose.BarCode for .NET.
1. Read the barcode from the image.

Use the [PdfExtractor](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdfextractor) class and bind it to the PDF document using PdfExtractor.BindPdf() method. Specify start and end page numbers and then call PdfExtractor.ExtractImage() method to get the images for the mentioned pages. In a while loop, call PdfExtractor.GetNextImage() method and save the image to stream. Initialize Aspose.BarCodeRecognition.BarCodeReader class with the stream and symbology type and then call BarCodeReader.Read() method to read the barcodes from the stream (image). The sample code snippet is given below:
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-TechnicalArticles-RecognizeBarcodeFromPDFDocuments-RecognizeBarcodeFromPDFDocuments.cs" >}}



The evaluation version of Aspose.BarCode for .NET provides limited functionality. For getting a temporary license for 30 days, please visit <http://www.aspose.com/corporate/purchase/temporary-license.aspx> for more details.
