//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using System.Drawing;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class AddBarcodeToWordDocumentFloatingEMF: WordIntegrationBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.WriteLine("AddBarcodeToWordDocumentFloatingEMF:");

            int Resolution = 300;//300 dpi high resolution of the barcode image
            int leftBarcodePosition = 10;//left position of the barcode image
            int topBarcodePosition = 20;//top pistion of the barcode image

            //create Word document
            Aspose.Words.Document wordDoc = new Aspose.Words.Document();
            Aspose.Words.DocumentBuilder wordBuilder = new Aspose.Words.DocumentBuilder(wordDoc);

            //create barcode image
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Pdf417, "Aspose.Barcode Pdf417 Example");
            generator.Parameters.Resolution = Resolution;//set the barcode image resolution
            Bitmap image = generator.GenerateBarCodeImage();
            MemoryStream imageStream = new MemoryStream();
            generator.Save(imageStream, BarCodeImageFormat.Emf);

            //insert barcode image as floating image from top/left position of the page
            wordBuilder.Write("First Sentence.");
            wordBuilder.InsertImage(imageStream.ToArray(),
                Aspose.Words.Drawing.RelativeHorizontalPosition.Page, leftBarcodePosition,
                Aspose.Words.Drawing.RelativeVerticalPosition.Page, topBarcodePosition,
                (image.Width * 72) / Resolution, (image.Height * 72) / Resolution, Aspose.Words.Drawing.WrapType.Square);
            wordBuilder.Write("Second Sentence.");

            //save the document
            wordDoc.Save($"{path}AddBarcodeToWordDocumentFloatingEMF.docx", Aspose.Words.SaveFormat.Docx);
        }
	}
}