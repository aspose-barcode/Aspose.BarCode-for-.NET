---
title: Export PDF Pages to Images and Recognize BarCode
type: docs
weight: 60
url: /net/export-pdf-pages-to-images-and-recognize-barcode/
---

## **Export PDF Pages to Images and Recognize BarCode**
In this article, we will recognize the barcode from a PDF document using Aspose.BarCode for .NET and Aspose.PDF for .NET. We will follow the below steps for reading barcode from the PDF document:

1. Export PDF page to image using Aspose.PDF for .NET.
1. Save the extracted image as a stream.
1. Pass the image in the form of the stream to Aspose.BarCode for .NET.
1. Read the barcode from the image.
1. Repeat the above steps until the end of the PDF document.

Use the [PdfConverter ](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdfconverter)class and bind it to the PDF document using PdfConverter.BindPdf() method. Specify start and end page numbers and then call PdfConverter.DoConvert() method to convert the mentioned page to an image. Call PdfConverter.GetNextImage() method and save the image to stream. Initialize Aspose.BarCodeRecognition.BarCodeReader class with the stream and symbology type and then call BarCodeReader.Read() method to read the barcodes from the stream (image). The sample code snippet is given below:
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-TechnicalArticles-ExportPDFPagesToImagesAndRecognizeBarCode-ExportPDFPagesToImagesAndRecognizeBarCode.cs" >}}



The evaluation version of Aspose.BarCode for .NET can only recognize Code39 barcodes. If the image contains a barcode of other than Code39 symbology type, a valid license must be set. For getting a temporary license for 30 days, please visit <http://www.aspose.com/corporate/purchase/temporary-license.aspx> for more details.
