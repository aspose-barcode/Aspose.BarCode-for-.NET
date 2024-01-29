//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrErrorLevel : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QrErrorLevel:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "A QR code is a type of matrix barcode invented in 1994"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                //set error level L
                gen.Parameters.Barcode.QR.QrErrorLevel = QRErrorLevel.LevelL;
                gen.Save($"{path}QrErrorLevelL.png", BarCodeImageFormat.Png);
                //set error level M
                gen.Parameters.Barcode.QR.QrErrorLevel = QRErrorLevel.LevelM;
                gen.Save($"{path}QrErrorLevelM.png", BarCodeImageFormat.Png);
                //set error level Q
                gen.Parameters.Barcode.QR.QrErrorLevel = QRErrorLevel.LevelQ;
                gen.Save($"{path}QrErrorLevelQ.png", BarCodeImageFormat.Png);
                //set error level H
                gen.Parameters.Barcode.QR.QrErrorLevel = QRErrorLevel.LevelH;
                gen.Save($"{path}QrErrorLevelH.png", BarCodeImageFormat.Png);
            }
        }
    }
}