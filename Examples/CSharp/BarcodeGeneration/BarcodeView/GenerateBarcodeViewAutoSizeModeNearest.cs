//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeViewAutoSizeModeNearest : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeViewAutoSizeModeNearest:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "ASPOSE");
            gen.Parameters.AutoSizeMode = AutoSizeMode.Nearest;
            gen.Parameters.ImageWidth.Pixels = 150;
            gen.Parameters.ImageHeight.Pixels = 150;
            gen.Parameters.Barcode.XDimension.Pixels = 9;
            gen.Save($"{path}AutoSizeModeNearest.png", BarCodeImageFormat.Png);
        }
	}
}