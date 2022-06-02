//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using System.Drawing;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class AddBarcodeToPDFDocumentWithOperators : PdfIntegrationBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.WriteLine("AddBarcodeToPDFDocumentWithOperators:");

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
            //Add image to pdf document, using operators
            //add image to resources and create placement matrix
            string pdfImageName = pdfPage.Resources.Images.Add(imageStream);
            Aspose.Pdf.Matrix matrix = new Aspose.Pdf.Matrix(new double[] { pdfRect.URX - pdfRect.LLX, 0, 0, pdfRect.URY - pdfRect.LLY, pdfRect.LLX, pdfRect.LLY });
            //save graphics state
            pdfPage.Contents.Add(new Aspose.Pdf.Operators.GSave());
            //set position of the next added image with ConcatenateMatrix
            pdfPage.Contents.Add(new Aspose.Pdf.Operators.ConcatenateMatrix(matrix));
            //draws image in previous placement
            pdfPage.Contents.Add(new Aspose.Pdf.Operators.Do(pdfImageName));
            //restore graphics state
            pdfPage.Contents.Add(new Aspose.Pdf.Operators.GRestore());

            //save PDF document
            pdfDoc.Save($"{path}AddBarcodeToPDFDocumentWithOperators.pdf");
        }
	}
}