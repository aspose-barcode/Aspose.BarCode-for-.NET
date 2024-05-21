//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;
using System;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Pdf417EncodeModeECI : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Pdf417EncodeModeECI:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "ΑΒΓΔΕ"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 15;
                gen.Parameters.Barcode.Pdf417.Pdf417EncodeMode = Pdf417EncodeMode.ECI;
                gen.Parameters.Barcode.Pdf417.Pdf417ECIEncoding = ECIEncodings.ISO_8859_7;
                gen.Save($"{path}Pdf417EncodeModeECI.png", BarCodeImageFormat.Png);

                using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.Pdf417))
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