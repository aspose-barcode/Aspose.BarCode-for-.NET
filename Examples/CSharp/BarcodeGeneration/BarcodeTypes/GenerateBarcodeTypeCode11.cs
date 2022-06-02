//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeTypeCode11: GenerateBarcodeTypeBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeTypeCode11:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code11, "1234-5678");
            gen.Save($"{path}Code11.png", BarCodeImageFormat.Png);
        }
	}
}