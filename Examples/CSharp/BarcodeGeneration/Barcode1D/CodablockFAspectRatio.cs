//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CodablockFAspectRatio : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CodablockFAspectRatio:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.CodablockF, "Aspose");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set CodablockF aspect ratio 15
            gen.Parameters.Barcode.Codablock.AspectRatio = 15;
            gen.Save($"{path}CodablockFAspectRatio15.png", BarCodeImageFormat.Png);
            //set CodablockF aspect ratio 30
            gen.Parameters.Barcode.Codablock.AspectRatio = 30;
            gen.Save($"{path}CodablockFAspectRatio30.png", BarCodeImageFormat.Png);
        }
    }
}