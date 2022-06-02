//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CodetextSpace : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CodetextSpace:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.Pdf417.Rows = 12;
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //codetext space 5 pixels
            gen.Parameters.Barcode.CodeTextParameters.Space.Pixels = 5;
            gen.Save($"{path}CodetextSpace5Pixels.png", BarCodeImageFormat.Png);
            //codetext space 40 pixels
            gen.Parameters.Barcode.CodeTextParameters.Space.Pixels = 40;
            gen.Save($"{path}CodetextSpace40Pixels.png", BarCodeImageFormat.Png);
        }
    }
}