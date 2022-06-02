//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class RecognizeBarcodesFromPDFDocumentWithPageDirectRendering : PdfIntegrationBase
    {
		public static void Run()
        {
            string path = GetReadFolder();
            Console.WriteLine("RecognizeBarcodesFromPDFDocumentWithPageDirectRendering:");

            using (Aspose.Pdf.Document pdfDoc = new Aspose.Pdf.Document($"{path}PDFDocumentWithPdf417.pdf"))
            {
                //proceed all pdf pages, pages start from 1
                for (int i = 1; i <= pdfDoc.Pages.Count; ++i)
                {
                    //render pdf page to the stream
                    MemoryStream ms = pdfDoc.Pages[i].ConvertToPNGMemoryStream();
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