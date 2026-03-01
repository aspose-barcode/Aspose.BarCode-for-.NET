//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class StoreBarcodeOutputAsPdf : StoreBarcodeOutputBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("StoreBarcodeOutputAsPdf:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "12345678");
            //save as Pdf with text 
            gen.Parameters.Image.Pdf.IsTextAsPath = false;
            gen.Save($"{path}VectorImagePdf_AsText.pdf", BarCodeImageFormat.Pdf);
            //save as Pdf with path 
            gen.Parameters.Image.Pdf.IsTextAsPath = true;
            gen.Save($"{path}VectorImagePdf_AsPath.pdf", BarCodeImageFormat.Pdf);
        }
    }
}