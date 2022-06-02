//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeTypeGS1Code128 : GenerateBarcodeTypeBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeTypeGS1Code128:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1Code128, "(02)04006664241007(37)1");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Save($"{path}GS1Code128.png", BarCodeImageFormat.Png);
        }
	}
}