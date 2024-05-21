//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrEncodeModeAuto : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QREncodeModeAuto:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "犬Right狗"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 10;
                gen.Save($"{path}QREncodeModeAuto.png", BarCodeImageFormat.Png);

                using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.QR))
                {
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                    {
                        Console.WriteLine($"CodeType:{result.CodeTypeName}");
                        Console.WriteLine($"CodeText:{result.CodeText}");
                    }
                }
            }
        }
    }
}