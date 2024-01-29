//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrVersionExample : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QRVersionExample:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "ASPOSE"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                
                //auto (by default)
                gen.Save($"{path}QRVersionAuto.png", BarCodeImageFormat.Png);

                //set QR version 05
                gen.Parameters.Barcode.QR.QrVersion = QRVersion.Version05;
                gen.Save($"{path}QRVersion05.png", BarCodeImageFormat.Png);
            }
        }
    }
}