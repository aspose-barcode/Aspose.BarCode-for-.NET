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
    internal class AddBarcodeToPDFDocumentDirectly : PdfIntegrationBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.WriteLine("AddBarcodeToPDFDocumentDirectly:");

            int Resolution = 300;//300 dpi high resolution of the barcode image
            int leftBarcodePosition = 10;//left position of the barcode image
            int topBarcodePosition = 20;//top pistion of the barcode image

            //create PDF document with new page
            Aspose.Pdf.Document pdfDoc = new Aspose.Pdf.Document();
            Aspose.Pdf.Page pdfPage = pdfDoc.Pages.Add();

            //create barcode image into png Stream
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Pdf417, "Aspose.Barcode Example");
            generator.Parameters.Resolution = Resolution;//set the barcode image resolution
            Bitmap image = generator.GenerateBarCodeImage();
            MemoryStream imageStream = new MemoryStream();
            generator.Save(imageStream, BarCodeImageFormat.Png);
            imageStream.Position = 0;

            //Rectangle where the image will be placed in top/left corner
            Rectangle imageRect = new Rectangle(leftBarcodePosition, topBarcodePosition, (image.Width * 72) / Resolution, (image.Height * 72) / Resolution);
            Aspose.Pdf.Rectangle pdfRect = new Aspose.Pdf.Rectangle(imageRect.Left, pdfPage.Rect.Height - imageRect.Bottom, imageRect.Right, pdfPage.Rect.Height - imageRect.Top);
            //add image to created PDF page
            pdfPage.AddImage(imageStream, pdfRect);

            //save PDF document
            pdfDoc.Save($"{path}AddBarcodeToPDFDocumentDirectly.pdf");
        }
	}
}