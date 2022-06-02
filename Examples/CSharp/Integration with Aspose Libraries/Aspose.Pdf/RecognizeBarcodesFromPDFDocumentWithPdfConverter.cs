//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using System.Drawing.Imaging;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class RecognizeBarcodesFromPDFDocumentWithPdfConverter : PdfIntegrationBase
    {
		public static void Run()
        {
            string path = GetReadFolder();
            Console.WriteLine("RecognizeBarcodesFromPDFDocumentWithPdfConverter:");

            using (Aspose.Pdf.Document pdfDoc = new Aspose.Pdf.Document($"{path}PDFDocumentWithPdf417.pdf"))
            {
                Aspose.Pdf.Facades.PdfConverter pdfConverter = new Aspose.Pdf.Facades.PdfConverter(pdfDoc);
                pdfConverter.RenderingOptions.BarcodeOptimization = true;

                //set resolution to the page
                //300 dpi is standard resolution
                pdfConverter.Resolution = new Aspose.Pdf.Devices.Resolution(300);

                //set all pages to render into images
                pdfConverter.StartPage = 1;//starts from 1
                pdfConverter.EndPage = pdfConverter.Document.Pages.Count;

                //render selected pages to the images
                pdfConverter.DoConvert();
                while (pdfConverter.HasNextImage())
                {
                    //render current page to memory stream as png image
                    MemoryStream ms = new MemoryStream();
                    pdfConverter.GetNextImage(ms, ImageFormat.Png);
                    ms.Position = 0;

                    //recognize Pdf417, QR and DataMatrix barcode types from rendered image of the page
                    BarCodeReader reader = new BarCodeReader(ms, DecodeType.Pdf417, DecodeType.QR, DecodeType.DataMatrix);
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                        Console.WriteLine($"Barcode type:{result.CodeTypeName}, Barcode Data:{result.CodeText}");
                }
            }
        }
	}
}