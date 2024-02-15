//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GS1MicroPdf417Mode903To905 : TwoDBase
    {
		public static void Run()
        {
			string path = GetFolder();
            System.Console.WriteLine("GS1MicroPdf417Mode903To905:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1MicroPdf417, "(01)12345678901231(240)ABCD123456789012345");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Pdf417.Columns = 4;
            //Micro Pdf417 Codewords 903 - 905, UCC/EAN-128 emulation
            gen.Save($"{path}GS1MicroPdf417Mode903To905.png", BarCodeImageFormat.Png);
            //try to recognize it
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.GS1MicroPdf417);
            foreach (BarCodeResult result in read.ReadBarCodes())
            {
                Console.WriteLine("CodeText:" + result.CodeText);
                Console.WriteLine("Pdf417_IsLinked:" + result.Extended.Pdf417.IsLinked);
            }
        }
	}
}