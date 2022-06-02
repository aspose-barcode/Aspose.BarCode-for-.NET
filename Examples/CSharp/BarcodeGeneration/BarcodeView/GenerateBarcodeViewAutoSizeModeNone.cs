//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeViewAutoSizeModeNone : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeViewAutoSizeModeNone:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "ASPOSE");
            gen.Parameters.AutoSizeMode = AutoSizeMode.None;
            gen.Parameters.ImageWidth.Pixels = 300;
            gen.Parameters.ImageHeight.Pixels = 300;
            gen.Parameters.Barcode.XDimension.Pixels = 9;
            gen.Save($"{path}AutoSizeModeNone.png", BarCodeImageFormat.Png);
        }
	}
}