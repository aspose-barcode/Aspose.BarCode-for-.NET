//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Encoding2DUnicodeUTF8: TwoDEncodingBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.WriteLine("Encoding2DUnicodeUTF8:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 8;
                gen.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.Auto;
                gen.SetCodeText("Aspose常に先を行", Encoding.UTF8);
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Aspose常に先を行";
                gen.Save($"{path}Encoding2DUnicodeUTF8.png", BarCodeImageFormat.Png);

                using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.QR))
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                        Console.WriteLine($"CodeText:{result.CodeText}");
            }
        }
    }
}