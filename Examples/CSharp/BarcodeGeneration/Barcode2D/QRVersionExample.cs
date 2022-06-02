//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QRVersionExample : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QRVersionExample:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "ASPOSE");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            //set MicroQR 4 version
            gen.Parameters.Barcode.QR.QrVersion = QRVersion.VersionM4;
            gen.Save($"{path}QRVersionM4.png", BarCodeImageFormat.Png);
            //set QR 5 version
            gen.Parameters.Barcode.QR.QrVersion = QRVersion.Version05;
            gen.Save($"{path}QRVersion05.png", BarCodeImageFormat.Png);
        }
    }
}