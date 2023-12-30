//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DotCodeEncodeModeAuto : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DotCodeEncodeModeAuto:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DotCode, "犬Right狗"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 10;

                //set DotCode ECI encoding to UTF8
                gen.Parameters.Barcode.DotCode.ECIEncoding = ECIEncodings.UTF8;
                gen.Save($"{path}DotCodeEncodeModeAuto.png", BarCodeImageFormat.Png);
            }
        }
    }
}