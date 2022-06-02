//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using System.Drawing;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.Integration
{
    internal class AddBarcodeToWordDocumentInline: WordIntegrationBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.WriteLine("AddBarcodeToWordDocumentInline:");

            int Resolution = 300;//300 dpi high resolution of the barcode image

            //create Word document
            Aspose.Words.Document wordDoc = new Aspose.Words.Document();
            Aspose.Words.DocumentBuilder wordBuilder = new Aspose.Words.DocumentBuilder(wordDoc);

            //create barcode image
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Pdf417, "Aspose.Barcode Pdf417 Example");
            generator.Parameters.Resolution = Resolution;//set the barcode image resolution
            Bitmap image = generator.GenerateBarCodeImage();
            MemoryStream imageStream = new MemoryStream();
            generator.Save(imageStream, BarCodeImageFormat.Png);

            //insert barcode image into the text
            wordBuilder.Write("First Sentence.");
            wordBuilder.InsertImage(imageStream.ToArray(), (image.Width * 72) / Resolution, (image.Height * 72) / Resolution);
            wordBuilder.Write("Second Sentence.");

            //save the document
            wordDoc.Save($"{path}AddBarcodeToWordDocumentInline.docx", Aspose.Words.SaveFormat.Docx);
        }
    }
}