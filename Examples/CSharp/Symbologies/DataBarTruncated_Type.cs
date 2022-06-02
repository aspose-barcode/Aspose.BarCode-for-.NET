//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class DataBarTruncated_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            //generate DataBar Truncated Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DatabarTruncated, "(01)12345678901231"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                //minimum of 13X high
                gen.Parameters.Barcode.BarHeight.Pixels = 26;
                gen.Save($"{path}DataBarTruncated.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("DataBarTruncated_Type:");
            //recognize DataBar Truncated Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}DataBarTruncated.png", DecodeType.DatabarTruncated, DecodeType.DatabarStacked))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}