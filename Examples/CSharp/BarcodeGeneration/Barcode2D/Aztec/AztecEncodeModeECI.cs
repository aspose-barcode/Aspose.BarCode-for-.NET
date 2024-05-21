//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;
using System;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecEncodeModeECI : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecEncodeModeECI:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, "ΑΒΓΔΕ"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 15;
                gen.Parameters.Barcode.Aztec.AztecEncodeMode = AztecEncodeMode.ECI;
                gen.Parameters.Barcode.Aztec.ECIEncoding = ECIEncodings.ISO_8859_7;
                gen.Save($"{path}AztecEncodeModeECI.png", BarCodeImageFormat.Png);

                using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.Aztec))
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