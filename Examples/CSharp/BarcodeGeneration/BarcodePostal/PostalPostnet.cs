//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class PostalPostnet : PostalBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("PostalPostnet:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Postnet, "123456");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Parameters.Barcode.Postal.PostalShortBarHeight.Pixels = 20;
            gen.Save($"{path}PostalPostnetBarcode.png", BarCodeImageFormat.Png);
        }
	}
}