//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class SupplementSpace : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("SupplementSpace:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.EAN13, "1234567890128");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Supplement.SupplementData = "12345";
            //set supplement space 20 pixels
            gen.Parameters.Barcode.Supplement.SupplementSpace.Pixels = 20;
            gen.Save($"{path}SupplementSpace20Pixels.png", BarCodeImageFormat.Png);
            //set supplement space 40 pixels
            gen.Parameters.Barcode.Supplement.SupplementSpace.Pixels = 40;
            gen.Save($"{path}SupplementSpace40Pixels.png", BarCodeImageFormat.Png);
        }
    }
}