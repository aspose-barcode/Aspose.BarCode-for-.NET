//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Encoding2DAlphanumeric : TwoDEncodingBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Encoding2DAlphanumeric:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "Aspose 2002-2024"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 8;
                gen.Parameters.Barcode.DataMatrix.DataMatrixEncodeMode = DataMatrixEncodeMode.Auto;
                gen.Save($"{path}Encoding2DAlphanumeric.png", BarCodeImageFormat.Png);

                using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.DataMatrix))
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                        Console.WriteLine($"CodeText:{result.CodeText}");
            }
        }
    }
}