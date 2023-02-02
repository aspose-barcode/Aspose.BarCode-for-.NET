//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MaxiCodeEncodeModeAuto : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeEncodeModeAuto:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MaxiCode, "犬Right狗"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 15;

                //set MaxiCode ECI encoding to UTF8
                gen.Parameters.Barcode.MaxiCode.ECIEncoding = ECIEncodings.UTF8;
                gen.Save($"{path}MaxiCodeEncodeModeAuto.png", BarCodeImageFormat.Png);
            }
        }
	}
}