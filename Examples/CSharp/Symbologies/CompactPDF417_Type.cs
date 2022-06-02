//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class CompactPDF417_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = Encoding.Unicode;
            //generate Compact PDF417 Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                //set Pdf417 truncated or Compact Pdf417
                gen.Parameters.Barcode.Pdf417.Pdf417Truncate = true;
                //set 3 columns
                gen.Parameters.Barcode.Pdf417.Columns = 3;
                //set error level 2
                gen.Parameters.Barcode.Pdf417.Pdf417ErrorLevel = Pdf417ErrorLevel.Level2;
                gen.Save($"{path}CompactPDF417.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("CompactPDF417_Type:");
            //recognize Compact PDF417 Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}CompactPDF417.png", DecodeType.Pdf417, DecodeType.CompactPdf417, DecodeType.MacroPdf417))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}