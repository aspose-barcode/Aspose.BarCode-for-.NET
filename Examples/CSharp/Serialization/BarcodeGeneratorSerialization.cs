//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
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
            gen.Parameters.Barcode.Pdf417.Pdf417MacroFileID = 12345678;
            gen.Parameters.Barcode.Pdf417.Pdf417MacroSegmentID = 12;
            gen.Parameters.Barcode.Pdf417.Pdf417MacroSegmentsCount = 20;
            gen.Parameters.Barcode.Pdf417.Pdf417MacroFileName = "file01";
            gen.Parameters.Barcode.Pdf417.Pdf417MacroChecksum = 1234;
            gen.Parameters.Barcode.Pdf417.Pdf417MacroFileSize = 400000;
            gen.Parameters.Barcode.Pdf417.Pdf417MacroTimeStamp = new DateTime(2019, 11, 1);
            gen.Parameters.Barcode.Pdf417.Pdf417MacroAddressee = "street";
            gen.Parameters.Barcode.Pdf417.Pdf417MacroSender = "aspose";
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