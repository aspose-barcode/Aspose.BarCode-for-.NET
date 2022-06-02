//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class AztecFull_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = Encoding.Unicode;
            //generate Aztec Full Range Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                //set symbol mode FullRange
                gen.Parameters.Barcode.Aztec.AztecSymbolMode = AztecSymbolMode.FullRange;
                //set error correction capacity to 10% (can be from 5% to 95%)
                gen.Parameters.Barcode.Aztec.AztecErrorLevel = 10;
                gen.Save($"{path}AztecFullRange.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("AztecFull_Type:");
            //recognize Aztec Full Range Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}AztecFullRange.png", DecodeType.Aztec))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}