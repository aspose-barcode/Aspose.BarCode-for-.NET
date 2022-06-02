//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeViewResolution : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeViewResolution:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "ASPOSE");
            //set unit size in 1 millimeter, resolution 96
            gen.Parameters.Barcode.XDimension.Millimeters = 1;
            gen.Parameters.Resolution = 96;
            gen.Save($"{path}UnitIn1MillimeterResolution96.png", BarCodeImageFormat.Png);
            //set unit size in 1 millimeter, resolution 300
            gen.Parameters.Barcode.XDimension.Millimeters = 1;
            gen.Parameters.Resolution = 300;
            gen.Save($"{path}UnitIn1MillimeterResolution300.png", BarCodeImageFormat.Png);

        }
    }
}