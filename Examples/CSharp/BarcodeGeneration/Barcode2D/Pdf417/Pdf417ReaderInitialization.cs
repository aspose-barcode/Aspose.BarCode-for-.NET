﻿//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Pdf417ReaderInitialization : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Pdf417ReaderInitialization:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Aspose");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Pdf417.Columns = 3;
            //set flag that indicates that data is encoded for reader initialization
            gen.Parameters.Barcode.Pdf417.IsReaderInitialization = true;
            gen.Save($"{path}Pdf417ReaderInitialization.png", BarCodeImageFormat.Png);
            //try to recognize it
            using (BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.Pdf417))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine("CodeText:" + result.CodeText);
                    Console.WriteLine("IsReaderInitialization:" + result.Extended.Pdf417.IsReaderInitialization);
                }
        }
    }
}