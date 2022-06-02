//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class AztecRune_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            //generate Aztec Rune Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, "123"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                //set symbol mode Rune
                gen.Parameters.Barcode.Aztec.AztecSymbolMode = AztecSymbolMode.Rune;
                gen.Save($"{path}AztecRune.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("AztecRune_Type:");
            //recognize Aztec Rune Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}AztecRune.png", DecodeType.Aztec))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}