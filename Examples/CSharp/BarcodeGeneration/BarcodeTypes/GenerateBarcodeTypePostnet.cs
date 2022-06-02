//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeTypePostnet : GenerateBarcodeTypeBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeTypePostnet:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Postnet, "1159628792");
            gen.Parameters.Barcode.XDimension.Pixels = 3;
            gen.Save($"{path}Postnet.png", BarCodeImageFormat.Png);
        }
	}
}