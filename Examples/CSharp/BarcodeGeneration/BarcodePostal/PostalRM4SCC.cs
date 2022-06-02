//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class PostalRM4SCC : PostalBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("PostalRM4SCC:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.RM4SCC, "123456ASPOSE");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Save($"{path}PostalRM4SCCBarcode.png", BarCodeImageFormat.Png);
        }
	}
}