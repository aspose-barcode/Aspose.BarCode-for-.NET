//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecEncodeModeAuto : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecEncodeModeAuto:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, "犬Right狗"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 15;

                //set Aztec ECI encoding to UTF8
                gen.Parameters.Barcode.Aztec.ECIEncoding = ECIEncodings.UTF8;
                gen.Save($"{path}AztecEncodeModeAuto.png", BarCodeImageFormat.Png);
            }
        }
	}
}