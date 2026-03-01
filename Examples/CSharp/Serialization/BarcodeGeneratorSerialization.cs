//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.Serialization
{
    internal class BarcodeGeneratorSerialization : SerializationBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("BarcodeGeneratorSerialization:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MacroPdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Pdf417.Columns = 4;
            //set PDF417 metadata
            gen.Parameters.Barcode.Pdf417.MacroPdf417FileID = 12345678;
            gen.Parameters.Barcode.Pdf417.MacroPdf417SegmentID = 12;
            gen.Parameters.Barcode.Pdf417.MacroPdf417SegmentsCount = 20;
            gen.Parameters.Barcode.Pdf417.MacroPdf417FileName = "file01";
            gen.Parameters.Barcode.Pdf417.MacroPdf417Checksum = 1234;
            gen.Parameters.Barcode.Pdf417.MacroPdf417FileSize = 400000;
            gen.Parameters.Barcode.Pdf417.MacroPdf417TimeStamp = new DateTime(2019, 11, 1);
            gen.Parameters.Barcode.Pdf417.MacroPdf417Addressee = "street";
            gen.Parameters.Barcode.Pdf417.MacroPdf417Sender = "aspose";
            //serialize BarcodeGenerator to file
            gen.ExportToXml($"{path}generatorMacroPdf417.xml");
            //generate original
            gen.Save($"{path}BarcodeGeneratorOriginal.png", BarCodeImageFormat.Png);

            //load BarcodeGenerator from file
            gen = BarcodeGenerator.ImportFromXml($"{path}generatorMacroPdf417.xml");
            //generate loaded
            gen.Save($"{path}BarcodeGeneratorLoaded.png", BarCodeImageFormat.Png);
        }
	}
}