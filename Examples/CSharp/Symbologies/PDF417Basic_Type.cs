//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class PDF417Basic_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = Encoding.Unicode;
            //generate PDF417 Basic Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                //set 3 columns
                gen.Parameters.Barcode.Pdf417.Columns = 3;
                //set error level 2
                gen.Parameters.Barcode.Pdf417.Pdf417ErrorLevel = Pdf417ErrorLevel.Level2;
                gen.Save($"{path}PDF417Basic.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("PDF417Basic_Type:");
            //recognize PDF417 Basic Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}PDF417Basic.png", DecodeType.Pdf417, DecodeType.CompactPdf417, DecodeType.MacroPdf417))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}