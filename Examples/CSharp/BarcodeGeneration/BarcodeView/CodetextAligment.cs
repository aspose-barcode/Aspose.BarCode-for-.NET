//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CodetextAligment : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CodetextAligment:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.Pdf417.Rows = 12;
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set Codetext Left alignment
            gen.Parameters.Barcode.CodeTextParameters.Alignment = TextAlignment.Left;
            gen.Save($"{path}CodetextAligmentLeft.png", BarCodeImageFormat.Png);
            //set Codetext Center alignment
            gen.Parameters.Barcode.CodeTextParameters.Alignment = TextAlignment.Center;
            gen.Save($"{path}CodetextAligmentCenter.png", BarCodeImageFormat.Png);
            //set Codetext Right alignment
            gen.Parameters.Barcode.CodeTextParameters.Alignment = TextAlignment.Right;
            gen.Save($"{path}CodetextAligmentRight.png", BarCodeImageFormat.Png);
        }
    }
}