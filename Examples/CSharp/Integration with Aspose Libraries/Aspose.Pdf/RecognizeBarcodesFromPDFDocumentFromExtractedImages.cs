//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using System.Drawing.Imaging;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class RecognizeBarcodesFromPDFDocumentFromExtractedImages : PdfIntegrationBase
    {
		public static void Run()
        {
            string path = GetReadFolder();
            Console.WriteLine("RecognizeBarcodesFromPDFDocumentFromExtractedImages:");

            using (Aspose.Pdf.Document pdfDoc = new Aspose.Pdf.Document($"{path}PDFDocumentWithPdf417.pdf"))
            {
                //proceed all pdf pages, pages start from 1
                for (int i = 1; i <= pdfDoc.Pages.Count; ++i)
                {
                    //create image extractor and bind to page
                    Aspose.Pdf.ImagePlacementAbsorber imagePlacementAbsorber = new Aspose.Pdf.ImagePlacementAbsorber();
                    imagePlacementAbsorber.Visit(pdfDoc.Pages[i]);

                    //proceed all images from pdf page
                    foreach (Aspose.Pdf.ImagePlacement imagePlacement in imagePlacementAbsorber.ImagePlacements)
                    {
                        //extract image from pdf page to the stream
                        MemoryStream ms = new MemoryStream();
                        imagePlacement.Save(ms, ImageFormat.Png);
                        ms.Position = 0;

                        //recognize Pdf417, QR and DataMatrix barcode types from extracted images from the page
                        BarCodeReader reader = new BarCodeReader(ms, DecodeType.Pdf417, DecodeType.QR, DecodeType.DataMatrix);
                        foreach (BarCodeResult result in reader.ReadBarCodes())
                            Console.WriteLine($"Barcode type:{result.CodeTypeName}, Barcode Data:{result.CodeText}");
                    }
                }
            }
        }
	}
}