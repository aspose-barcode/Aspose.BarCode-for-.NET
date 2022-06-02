//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class PostalFilledBars : PostalBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("PostalFilledBars:");

            BarcodeGenerator gen = null;
            //set Planet barcode filled bars
            gen = new BarcodeGenerator(EncodeTypes.Planet, "123456");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Save($"{path}PostalPlanetFilledBars.png", BarCodeImageFormat.Png);
            //set RM4SCC barcode filled bars
            gen = new BarcodeGenerator(EncodeTypes.RM4SCC, "123456");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Save($"{path}PostalRM4SCCFilledBars.png", BarCodeImageFormat.Png);
            //set Planet barcode empty bars
            gen = new BarcodeGenerator(EncodeTypes.Planet, "123456");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.FilledBars = false;
            gen.Save($"{path}PostalPlanetEmptyBars.png", BarCodeImageFormat.Png);
            //set RM4SCC barcode empty bars
            gen = new BarcodeGenerator(EncodeTypes.RM4SCC, "123456");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.FilledBars = false;
            gen.Save($"{path}PostalRM4SCCEmptyBars.png", BarCodeImageFormat.Png);
        }
    }
}