﻿//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;
using System;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MaxiCodeEncodeModeAuto : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeEncodeModeAuto:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MaxiCode, "犬Right狗"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 15;

                //set MaxiCode ECI encoding to UTF8
                gen.Save($"{path}MaxiCodeEncodeModeAuto.png", BarCodeImageFormat.Png);

                using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.MaxiCode))
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