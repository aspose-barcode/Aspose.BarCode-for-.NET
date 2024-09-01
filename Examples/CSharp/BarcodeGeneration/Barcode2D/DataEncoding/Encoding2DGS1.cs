//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Encoding2DGS1: TwoDEncodingBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Encoding2DGS1:");
            
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1QR, "(01)12345678901231(21)ASPOSE(30)9876"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 8;
                gen.Save($"{path}Encoding2DGS1.png", BarCodeImageFormat.Png);

                using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.GS1QR))
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                        Console.WriteLine($"CodeText:{result.CodeText}");
            }

        }
    }
}