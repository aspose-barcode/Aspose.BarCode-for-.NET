//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeTypePdf417 : GenerateBarcodeTypeBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeTypePdf417:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.Pdf417.Rows = 6;
            gen.Save($"{path}Pdf417.png", BarCodeImageFormat.Png);
        }
	}
}