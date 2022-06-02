//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrEncodeModeECIEncoding : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QrEncodeModeECIEncoding:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "Aspose常に先を行く");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            Console.OutputEncoding = Encoding.Unicode;
            //set encode mode to ECIEncoding and ECI to UTF8
            gen.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.ECIEncoding;
            gen.Parameters.Barcode.QR.QrECIEncoding = ECIEncodings.UTF8;
            gen.Save($"{path}QrEncodeModeECIEncoding.png", BarCodeImageFormat.Png);
            //try to recognize it
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.QR);
            foreach (BarCodeResult result in read.ReadBarCodes())
                Console.WriteLine("QrEncodeModeECIEncoding:" + result.CodeText);
        }
    }
}