//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class PostalShortBarHeight : PostalBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("PostalShortBarHeight:");

            BarcodeGenerator gen = null;
            //set Planet barcode ShortBarHeight 10 pixels
            gen = new BarcodeGenerator(EncodeTypes.Planet, "123456");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Parameters.Barcode.Postal.PostalShortBarHeight.Pixels = 10;
            gen.Save($"{path}PostalPlanetShortBarHeight10Pixels.png", BarCodeImageFormat.Png);
            //set Planet barcode ShortBarHeight 30 pixels
            gen = new BarcodeGenerator(EncodeTypes.Planet, "123456");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Parameters.Barcode.Postal.PostalShortBarHeight.Pixels = 30;
            gen.Save($"{path}PostalPlanetShortBarHeight30Pixels.png", BarCodeImageFormat.Png);
        }
	}
}