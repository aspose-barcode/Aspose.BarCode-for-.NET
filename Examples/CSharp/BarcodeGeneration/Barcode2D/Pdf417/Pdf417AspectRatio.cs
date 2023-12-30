//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Pdf417AspectRatio : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Pdf417AspectRatio:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Pdf417.Columns = 3;
            //set aspect ratio to 2
            gen.Parameters.Barcode.Pdf417.AspectRatio = 2;
            gen.Save($"{path}Pdf417AspectRatio2.png", BarCodeImageFormat.Png);
            //set aspect ratio to 5
            gen.Parameters.Barcode.Pdf417.AspectRatio = 5;
            gen.Save($"{path}Pdf417AspectRatio5.png", BarCodeImageFormat.Png);
        }
    }
}