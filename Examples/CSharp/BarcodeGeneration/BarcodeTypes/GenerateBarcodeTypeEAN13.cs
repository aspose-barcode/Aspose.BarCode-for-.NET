//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeTypeEAN13 : GenerateBarcodeTypeBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeTypeEAN13:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.EAN13, "1234567890128");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Save($"{path}Ean13.png", BarCodeImageFormat.Png);
        }
	}
}