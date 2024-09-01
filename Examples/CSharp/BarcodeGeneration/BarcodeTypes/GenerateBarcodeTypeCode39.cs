//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeTypeCode39 : GenerateBarcodeTypeBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeTypeCode39:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code39FullASCII, "$&This Code#*");
            gen.Save($"{path}Code39FullASCII.png", BarCodeImageFormat.Png);
        }
	}
}