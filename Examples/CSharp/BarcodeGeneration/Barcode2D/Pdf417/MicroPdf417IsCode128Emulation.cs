//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MicroPdf417IsCode128Emulation : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MicroPdf417IsCode128Emulation:");

            //Encodes MicroPdf417 in Code 128 emulation mode with FNC1 in second position and Application Indicator "a", mode 908.
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MicroPdf417, "a\u001d1222322323");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Pdf417.Columns = 4;
            gen.Parameters.Barcode.Pdf417.IsCode128Emulation = true;
            gen.Save($"{path}MicroPdf417IsCode128Emulation_fnc1a.png", BarCodeImageFormat.Png);
            //try to recognize it
            using (BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.MicroPdf417))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine("CodeText:" + result.CodeText);
                    Console.WriteLine("IsCode128Emulation:" + result.Extended.Pdf417.IsCode128Emulation);
                }

            //Encodes MicroPdf417 in Code 128 emulation mode with FNC1 in second position and Application Indicator "99", mode 909.
            gen.CodeText = "99\u001d1222322323";
            gen.Save($"{path}MicroPdf417IsCode128Emulation_fnc199.png", BarCodeImageFormat.Png);
            //try to recognize it
            using (BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.MicroPdf417))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine("CodeText:" + result.CodeText);
                    Console.WriteLine("IsCode128Emulation:" + result.Extended.Pdf417.IsCode128Emulation);
                }

            //Encodes MicroPdf417 in Code 128 emulation mode, modes 910, 911
            gen.CodeText = "123456789012345678";
            gen.Save($"{path}MicroPdf417IsCode128Emulation.png", BarCodeImageFormat.Png);
            //try to recognize it
            using (BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.MicroPdf417))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine("CodeText:" + result.CodeText);
                    Console.WriteLine("IsCode128Emulation:" + result.Extended.Pdf417.IsCode128Emulation);
                }
        }
    }
}