//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeTypeQR : GenerateBarcodeTypeBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeTypeQR:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "Aspose常に先を行く");
            gen.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.ECIEncoding;
            gen.Parameters.Barcode.QR.QrECIEncoding = ECIEncodings.UTF8;
            gen.Parameters.Barcode.XDimension.Pixels = 5;
            gen.Save($"{path}QrCode.png", BarCodeImageFormat.Png);
        }
    }
}