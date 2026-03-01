//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MacroPdf417Optional : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MacroPdf417Optional:");
            Console.OutputEncoding = Encoding.Unicode;

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MacroPdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Pdf417.Columns = 4;
            //set metadata
            gen.Parameters.Barcode.Pdf417.MacroPdf417FileID = 12345678;
            gen.Parameters.Barcode.Pdf417.MacroPdf417SegmentID = 12;
            gen.Parameters.Barcode.Pdf417.MacroPdf417SegmentsCount = 20;
            gen.Parameters.Barcode.Pdf417.MacroPdf417FileName = "file01";
            //checksumm must be calculated in CCITT-16 / CRC-16-CCITT encoding
            //https://en.wikipedia.org/wiki/Cyclic_redundancy_check#Polynomial_representations_of_cyclic_redundancy_checks
            //for the example we use random number
            gen.Parameters.Barcode.Pdf417.MacroPdf417Checksum = 1234;
            gen.Parameters.Barcode.Pdf417.MacroPdf417FileSize = 400000;
            gen.Parameters.Barcode.Pdf417.MacroPdf417TimeStamp = new DateTime(2019, 11, 1);
            gen.Parameters.Barcode.Pdf417.MacroPdf417Addressee = "street";
            gen.Parameters.Barcode.Pdf417.MacroPdf417Sender = "aspose";
            gen.Parameters.Barcode.Pdf417.MacroPdf417Terminator = Pdf417MacroTerminator.Set;
            gen.Save($"{path}MacroPdf417Optional.png", BarCodeImageFormat.Png);
            //try to recognize it
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.MacroPdf417);
            foreach (BarCodeResult result in read.ReadBarCodes())
            {
                Console.WriteLine("---MacroPdf417Optional---");
                Console.WriteLine("Codetext:" + result.CodeText);
                Console.WriteLine("Pdf417MacroFileID:" + result.Extended.Pdf417.MacroPdf417FileID);
                Console.WriteLine("Pdf417MacroSegmentID:" + result.Extended.Pdf417.MacroPdf417SegmentID.ToString());
                Console.WriteLine("Pdf417MacroSegmentsCount:" + result.Extended.Pdf417.MacroPdf417SegmentsCount.ToString());
                Console.WriteLine("Pdf417MacroFileName:" + result.Extended.Pdf417.MacroPdf417FileName);
                Console.WriteLine("Pdf417MacroChecksum:" + result.Extended.Pdf417.MacroPdf417Checksum.ToString());
                Console.WriteLine("Pdf417MacroFileSize:" + result.Extended.Pdf417.MacroPdf417FileSize.ToString());
                Console.WriteLine("Pdf417MacroTimeStamp:" + result.Extended.Pdf417.MacroPdf417TimeStamp.ToString());
                Console.WriteLine("Pdf417MacroAddressee:" + result.Extended.Pdf417.MacroPdf417Addressee);
                Console.WriteLine("Pdf417MacroSender:" + result.Extended.Pdf417.MacroPdf417Sender);
                Console.WriteLine("Pdf417MacroTerminator:" + result.Extended.Pdf417.MacroPdf417Terminator);
            }
        }
	}
}