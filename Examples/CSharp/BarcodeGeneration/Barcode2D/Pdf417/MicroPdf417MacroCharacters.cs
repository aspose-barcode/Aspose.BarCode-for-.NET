//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MicroPdf417MacroCharacters : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MicroPdf417MacroCharacters:");

            //Encodes MicroPdf417 Codewords 916 Macro strings 05
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MicroPdf417, "12345ABC");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Pdf417.Columns = 4;
            gen.Parameters.Barcode.Pdf417.MacroCharacters = MacroCharacter.Macro05;
            gen.Save($"{path}MicroPdf417MacroCharacters_Macro05.png", BarCodeImageFormat.Png);
            //try to recognize it
            using (BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.MicroPdf417))
                foreach (BarCodeResult result in read.ReadBarCodes())
                    Console.WriteLine("CodeText:" + result.CodeText);

            //Encodes MicroPdf417 Codewords 917 Macro strings 06
            gen.Parameters.Barcode.Pdf417.MacroCharacters = MacroCharacter.Macro06;
            gen.Save($"{path}MicroPdf417MacroCharacters_Macro06.png", BarCodeImageFormat.Png);
            //try to recognize it
            using (BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.MicroPdf417))
                foreach (BarCodeResult result in read.ReadBarCodes())
                    Console.WriteLine("CodeText:" + result.CodeText);
        }
    }
}