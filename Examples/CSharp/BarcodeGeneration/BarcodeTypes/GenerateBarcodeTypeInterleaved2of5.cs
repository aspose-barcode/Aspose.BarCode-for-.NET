//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeTypeInterleaved2of5: GenerateBarcodeTypeBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeTypeInterleaved2of5:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Interleaved2of5, "1234567890");
            gen.Save($"{path}Interleaved2of5.png", BarCodeImageFormat.Png);
        }
	}
}