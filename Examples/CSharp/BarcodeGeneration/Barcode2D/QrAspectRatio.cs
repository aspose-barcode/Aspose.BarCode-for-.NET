//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrAspectRatio : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QrAspectRatio:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "ASPOSE");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            //set Aspect Ratio to 1
            gen.Parameters.Barcode.QR.AspectRatio = 1;
            gen.Save($"{path}QrAspectRatio1.png", BarCodeImageFormat.Png);
            //set Aspect Ratio to 2
            gen.Parameters.Barcode.QR.AspectRatio = 2;
            gen.Save($"{path}QrAspectRatio2.png", BarCodeImageFormat.Png);
        }
    }
}