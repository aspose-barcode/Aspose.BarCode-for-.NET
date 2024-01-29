//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrMicroQRVersion : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MicroQRVersion:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MicroQR, "ASPOSE"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;

                //auto (by default)
                gen.Save($"{path}MicroQRVersionAuto.png", BarCodeImageFormat.Png);

                //set MicroQR M4 version
                gen.Parameters.Barcode.QR.MicroQRVersion = Generation.MicroQRVersion.M4;
                gen.Save($"{path}MicroQRVersionM4.png", BarCodeImageFormat.Png);
            }
        }
    }
}