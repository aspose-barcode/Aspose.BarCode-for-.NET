//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Encoding2DUnicodeCustom: TwoDEncodingBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.WriteLine("Encoding2DUnicodeCustom:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 8;
                gen.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.Auto;
                gen.SetCodeText("AsposeΣΑΩ", Encoding.GetEncoding(1253));
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "AsposeΣΑΩ";
                gen.Save($"{path}Encoding2DUnicodeCustom.png", BarCodeImageFormat.Png);

                using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.QR))
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                    {
                        Console.WriteLine($"Undecoded CodeText:{result.CodeText}");
                        Console.WriteLine($"CodeText:{result.GetCodeText(Encoding.GetEncoding(1253))}");
                    }
            }
        }
    }
}