//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class Code128_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            //generate Code128 Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "Aspose"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Save($"{path}Code128.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("Code128_Type:");
            //recognize Code128 Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}Code128.png", DecodeType.Code128))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}