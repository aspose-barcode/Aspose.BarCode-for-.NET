//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class DataBarLimited_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            //generate DataBar Limited Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DatabarLimited, "(01)12345678901231"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Save($"{path}DataBarLimited.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("DataBarLimited_Type:");
            //recognize DataBar Limited Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}DataBarLimited.png", DecodeType.DatabarLimited))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}