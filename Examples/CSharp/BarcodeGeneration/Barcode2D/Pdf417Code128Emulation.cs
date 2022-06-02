//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Pdf417Code128Emulation : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Pdf417Code128Emulation:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Aspose");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Pdf417.Columns = 3;
            //set flag that encoded data mest be decoded as Code128
            gen.Parameters.Barcode.Pdf417.Code128Emulation = Code128Emulation.Code903;
            gen.Save($"{path}Pdf417Code128Emulation.png", BarCodeImageFormat.Png);
        }
	}
}