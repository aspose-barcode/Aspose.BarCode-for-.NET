//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;
using System;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DataMatrixEncodeModeECI : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DataMatrixEncodeModeECI:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "ΑΒΓΔΕ"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 15;
                gen.Parameters.Barcode.DataMatrix.DataMatrixEncodeMode = DataMatrixEncodeMode.ECI;
                gen.Parameters.Barcode.DataMatrix.ECIEncoding = ECIEncodings.ISO_8859_7;
                gen.Save($"{path}DataMatrixEncodeModeECI.png", BarCodeImageFormat.Png);

                using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.DataMatrix))
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