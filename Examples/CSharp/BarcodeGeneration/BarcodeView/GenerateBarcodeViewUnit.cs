//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeViewUnit : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeViewUnit:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "ASPOSE");
            //set unit size in 3 pixels
            gen.Parameters.Barcode.XDimension.Pixels = 3;
            gen.Save($"{path}UnitIn3Pixels.png", BarCodeImageFormat.Png);
            //set unit size in 2 millimeters
            gen.Parameters.Barcode.XDimension.Millimeters = 2;
            gen.Save($"{path}UnitIn2Millimeters.png", BarCodeImageFormat.Png);
        }
    }
}