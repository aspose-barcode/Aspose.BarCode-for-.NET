//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class DataBarOmniDirectional_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            //generate DataBar OmniDirectional Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DatabarOmniDirectional, "(01)12345678901231"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Save($"{path}DataBarOmniDirectional.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("DataBarOmniDirectional_Type:");
            //recognize DataBar OmniDirectional Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}DataBarOmniDirectional.png", DecodeType.DatabarOmniDirectional, DecodeType.DatabarStackedOmniDirectional))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}