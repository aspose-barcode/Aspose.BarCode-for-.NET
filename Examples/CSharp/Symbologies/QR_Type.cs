//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class QR_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = Encoding.Unicode;
            //generate QR Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "Aspose常に先を行く"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                //set error correction level 7%
                gen.Parameters.Barcode.QR.ErrorLevel = QRErrorLevel.LevelL;
                //set ECI encoding UTF8
                gen.Parameters.Barcode.QR.EncodeMode = QREncodeMode.ECI;
                gen.Parameters.Barcode.QR.ECIEncoding = ECIEncodings.UTF8;
                //set version 5 can be Auto
                gen.Parameters.Barcode.QR.Version = QRVersion.Version05;
                gen.Save($"{path}QR.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("QR_Type:");
            //recognize QR Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}QR.png", DecodeType.QR))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
    }
}