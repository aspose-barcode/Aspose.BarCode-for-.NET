//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class DataBarExpandedStacked_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            //generate DataBar Expanded Stacked Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DatabarExpandedStacked, "(01)12345678901231(21)SERIAL1234"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.DataBar.IsAllowOnlyGS1Encoding = true;
                //set 3 rows
                gen.Parameters.Barcode.DataBar.Rows = 3;
                gen.Save($"{path}DataBarExpandedStacked.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("DataBarExpandedStacked_Type:");
            //recognize DataBar Expanded Stacked Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}DataBarExpandedStacked.png", DecodeType.DatabarExpanded, DecodeType.DatabarExpandedStacked))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}