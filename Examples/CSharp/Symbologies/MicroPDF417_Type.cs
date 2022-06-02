//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class MicroPDF417_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            //generate Micro PDF417 Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MicroPdf417, "Aspose"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Save($"{path}MicroPDF417.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("MicroPDF417_Type:");
            //recognize Micro PDF417 Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}MicroPDF417.png", DecodeType.MicroPdf417))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}