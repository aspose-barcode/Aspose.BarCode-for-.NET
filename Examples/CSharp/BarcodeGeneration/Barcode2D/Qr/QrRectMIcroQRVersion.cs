//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrRectMIcroQRVersion : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("RectMicroQRVersionExample:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.RectMicroQR, "ASPOSE"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;

                //auto (by default)
                gen.Save($"{path}RectMicroQRVersionAuto.png", BarCodeImageFormat.Png);

                //set RectMicroQR R11x77 version
                gen.Parameters.Barcode.QR.RectMicroQrVersion = Generation.RectMicroQRVersion.R11x77;
                gen.Save($"{path}RectMicroQRVersionR11x77.png", BarCodeImageFormat.Png);
            }
        }
    }
}