//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Gs1Code128Example : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Gs1Code128Example:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1Code128, "(01)12345678901231(21)ASPOSE(30)9876");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Save($"{path}GS1Code128Example.png", BarCodeImageFormat.Png);
        }
	}
}