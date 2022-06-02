//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QREncodeTypeExample : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QREncodeTypeExample:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "ASPOSE");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            //set Auto version
            gen.Parameters.Barcode.QR.QrVersion = QRVersion.Auto;
            //Set Auto QR encode type
            gen.Parameters.Barcode.QR.QrEncodeType = QREncodeType.Auto;
            gen.Save($"{path}QREncodeTypeAuto.png", BarCodeImageFormat.Png);
            //Set ForceMicroQR QR encode type
            gen.Parameters.Barcode.QR.QrEncodeType = QREncodeType.ForceMicroQR;
            gen.Save($"{path}QREncodeTypeForceMicroQR.png", BarCodeImageFormat.Png);
            //Set ForceQR QR encode type
            gen.Parameters.Barcode.QR.QrEncodeType = QREncodeType.ForceQR;
            gen.Save($"{path}QREncodeTypeForceQR.png", BarCodeImageFormat.Png);
        }
    }
}