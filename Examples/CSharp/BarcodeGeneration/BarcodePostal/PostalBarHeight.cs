//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class PostalBarHeight : PostalBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("PostalBarHeight:");

            BarcodeGenerator gen = null;
            //set Planet barcode BarHeight none
            gen = new BarcodeGenerator(EncodeTypes.Planet, "123456");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Save($"{path}PostalPlanetBarHeightNone.png", BarCodeImageFormat.Png);
            //set RM4SCC barcode BarHeight none
            gen = new BarcodeGenerator(EncodeTypes.RM4SCC, "123456");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Save($"{path}PostalRM4SCCBarHeightNone.png", BarCodeImageFormat.Png);
            //set Planet barcode BarHeight 100 pixels
            gen = new BarcodeGenerator(EncodeTypes.Planet, "123456");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 100;
            gen.Save($"{path}PostalPlanetBarHeight100Pixels.png", BarCodeImageFormat.Png);
            //set RM4SCC barcode BarHeight 100 pixels
            gen = new BarcodeGenerator(EncodeTypes.RM4SCC, "123456");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 100;
            gen.Save($"{path}PostalRM4SCCBarHeight100Pixels.png", BarCodeImageFormat.Png);
        }
    }
}