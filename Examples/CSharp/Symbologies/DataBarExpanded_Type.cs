//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class DataBarExpanded_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            //generate DataBar Expanded Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DatabarExpanded, "(01)12345678901231(21)SERIAL1234"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.DataBar.IsAllowOnlyGS1Encoding = true;
                gen.Save($"{path}DataBarExpanded.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("DataBarExpanded_Type:");
            //recognize DataBar Expanded Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}DataBarExpanded.png", DecodeType.DatabarExpanded, DecodeType.DatabarExpandedStacked))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}