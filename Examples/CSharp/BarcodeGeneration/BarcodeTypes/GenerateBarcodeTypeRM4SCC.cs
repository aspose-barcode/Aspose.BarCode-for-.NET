//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeTypeRM4SCC : GenerateBarcodeTypeBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeTypeRM4SCC:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.RM4SCC, "N101HU9Z");
            gen.Parameters.Barcode.XDimension.Pixels = 3;
            gen.Save($"{path}RM4SCC.png", BarCodeImageFormat.Png);
        }
	}
}