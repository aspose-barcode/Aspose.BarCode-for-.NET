//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class Code39_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            //generate Code39 Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code39Extended, "Aspose"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Save($"{path}Code39.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("Code39_Type:");
            //recognize Code39 Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}Code39.png", DecodeType.Code39Standard, DecodeType.Code39Extended))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}