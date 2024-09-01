//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Encoding2DUnicodeECI: TwoDEncodingBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.WriteLine("Encoding2DUnicodeECI:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "Aspose常に先を行"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 8;
                gen.Parameters.Barcode.DataMatrix.DataMatrixEncodeMode = DataMatrixEncodeMode.ECI;
                gen.Parameters.Barcode.DataMatrix.ECIEncoding = ECIEncodings.UTF8;
                gen.Save($"{path}Encoding2DUnicodeECI.png", BarCodeImageFormat.Png);

                using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.DataMatrix))
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                        Console.WriteLine($"CodeText:{result.CodeText}");
            }
        }
    }
}