//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class SupplementData : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("SupplementData:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.EAN13, "1234567890128");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Supplement.SupplementSpace.Pixels = 20;
            //set EAN2 supplement
            gen.Parameters.Barcode.Supplement.SupplementData = "12";
            gen.Save($"{path}SupplementEAN2.png", BarCodeImageFormat.Png);
            //set EAN5 supplement
            gen.Parameters.Barcode.Supplement.SupplementData = "12345";
            gen.Save($"{path}SupplementEAN5.png", BarCodeImageFormat.Png);
        }
    }
}