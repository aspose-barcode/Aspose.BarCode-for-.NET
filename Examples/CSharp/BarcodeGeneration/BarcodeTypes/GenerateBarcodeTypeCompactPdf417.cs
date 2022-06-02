//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeTypeCompactPdf417 : GenerateBarcodeTypeBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeTypeCompactPdf417:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            //Compact version of Pdf417
            gen.Parameters.Barcode.Pdf417.Pdf417Truncate = true;
            gen.Parameters.Barcode.Pdf417.Rows = 6;
            gen.Save($"{path}CompactPdf417.png", BarCodeImageFormat.Png);
        }
	}
}