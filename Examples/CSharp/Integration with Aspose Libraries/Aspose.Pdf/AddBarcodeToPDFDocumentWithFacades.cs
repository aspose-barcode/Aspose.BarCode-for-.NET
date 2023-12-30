//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using Aspose.BarCode.Generation;
#if NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_1_OR_GREATER
using Aspose.Drawing;
#else
using System.Drawing;
#endif

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class AddBarcodeToPDFDocumentWithFacades : PdfIntegrationBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.WriteLine("AddBarcodeToPDFDocumentWithFacades:");
            
            int Resolution = 300;//300 dpi high resolution of the barcode image
            int leftBarcodePosition = 10;//left position of the barcode image
            int topBarcodePosition = 20;//top pistion of the barcode image

            //create PDF document and add page
            Aspose.Pdf.Document pdfDoc = new Aspose.Pdf.Document();
            pdfDoc.Pages.Add();

            //create barcode image into png Stream
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Pdf417, "Aspose.Barcode Example");
            generator.Parameters.Resolution = Resolution;//set the barcode image resolution
            Bitmap image = generator.GenerateBarCodeImage();
            MemoryStream imageStream = new MemoryStream();
            generator.Save(imageStream, BarCodeImageFormat.Png);
            imageStream.Position = 0;

            //create mender and bind pdf document
            Aspose.Pdf.Facades.PdfFileMend mender = new Aspose.Pdf.Facades.PdfFileMend();
            mender.BindPdf(pdfDoc);

            //Place the image on page 1 in top/left corner
            Rectangle imageRect = new Rectangle(leftBarcodePosition, topBarcodePosition, (image.Width * 72) / Resolution, (image.Height * 72) / Resolution);
            //page to acquire the box to calculate top/left corner
            Aspose.Pdf.Page pdfPage = pdfDoc.Pages[1];
            mender.AddImage(imageStream, 1, imageRect.Left, (float)pdfPage.Rect.Height - imageRect.Bottom, imageRect.Right, (float)pdfPage.Rect.Height - imageRect.Top);

            //save PDF document with mender
            mender.Save($"{path}AddBarcodeToPDFDocumentWithFacades.pdf");
        }
	}
}