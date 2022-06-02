//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeTypeCode93 : GenerateBarcodeTypeBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeTypeCode93:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code93Extended, "$&This Code#*");
            gen.Save($"{path}Code93Extended.png", BarCodeImageFormat.Png);
        }
	}
}