//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GS1MicroPdf417Mode914And915 : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GS1MicroPdf417Mode914And915:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1MicroPdf417, "(10)ABCD12345(240)ABCD");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Pdf417.Columns = 3;
            gen.Parameters.Barcode.Pdf417.IsLinked = true;
            //Micro Pdf417 Codewords 914 - "Linked" UCC/EAN-128 implied GS1 "10" AI
            gen.Save($"{path}GS1MicroPdf417Mode914.png", BarCodeImageFormat.Png);
            //Micro Pdf417 Codewords 915 - "Linked" UCC/EAN-128 implied GS1 "21" AI
            gen.CodeText = "(21)ABCD12345(240)ABCD";
            gen.Save($"{path}GS1MicroPdf417Mode915.png", BarCodeImageFormat.Png);
        }
	}
}