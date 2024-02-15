//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtPDF417Meta : ReadExtendedBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.OutputEncoding = Encoding.Unicode;

            //generate MacroPdf417 with metadata
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MacroPdf417, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.Pdf417.Columns = 5;
                gen.Parameters.Barcode.Pdf417.Pdf417MacroFileID = 12345678;
                gen.Parameters.Barcode.Pdf417.Pdf417MacroSegmentID = 12;
                gen.Parameters.Barcode.Pdf417.Pdf417MacroSegmentsCount = 20;
                gen.Parameters.Barcode.Pdf417.Pdf417MacroFileName = "file01";
                //checksumm must be calculated in CCITT-16 / CRC-16-CCITT encoding
                //https://en.wikipedia.org/wiki/Cyclic_redundancy_check#Polynomial_representations_of_cyclic_redundancy_checks
                //for the example we use random number
                gen.Parameters.Barcode.Pdf417.Pdf417MacroChecksum = 1234;
                gen.Parameters.Barcode.Pdf417.Pdf417MacroFileSize = 400000;
                gen.Parameters.Barcode.Pdf417.Pdf417MacroTimeStamp = new DateTime(2019, 11, 1);
                gen.Parameters.Barcode.Pdf417.Pdf417MacroAddressee = "street";
                gen.Parameters.Barcode.Pdf417.Pdf417MacroSender = "aspose";
                gen.Parameters.Barcode.Pdf417.Pdf417MacroTerminator = Pdf417MacroTerminator.Set;
                gen.Save($"{path}ExtPDF417Meta.png", BarCodeImageFormat.Png);
            }

            //try to recognize Pdf417 metadata
            Console.WriteLine("ReadExtPDF417Meta:");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtPDF417Meta.png", DecodeType.MacroPdf417))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"Pdf417MacroFileID:{result.Extended.Pdf417.MacroPdf417FileID}");
                    Console.WriteLine($"Pdf417MacroSegmentID:{result.Extended.Pdf417.MacroPdf417SegmentID.ToString()}");
                    Console.WriteLine($"Pdf417MacroSegmentsCount:{result.Extended.Pdf417.MacroPdf417SegmentsCount.ToString()}");
                    Console.WriteLine($"Pdf417MacroFileName:{result.Extended.Pdf417.MacroPdf417FileName}");
                    Console.WriteLine($"Pdf417MacroChecksum:{result.Extended.Pdf417.MacroPdf417Checksum.ToString()}");
                    Console.WriteLine($"Pdf417MacroFileSize:{result.Extended.Pdf417.MacroPdf417FileSize.ToString()}");
                    Console.WriteLine($"Pdf417MacroTimeStamp:{result.Extended.Pdf417.MacroPdf417TimeStamp.ToString()}");
                    Console.WriteLine($"Pdf417MacroAddressee:{result.Extended.Pdf417.MacroPdf417Addressee}");
                    Console.WriteLine($"Pdf417MacroSender:{result.Extended.Pdf417.MacroPdf417Sender}");
                    Console.WriteLine($"MacroPdf417Terminator:{result.Extended.Pdf417.MacroPdf417Terminator}");
                }
            }

            //generate MacroPdf417 with Reader Initialization
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.Pdf417.Columns = 5;
                gen.Parameters.Barcode.Pdf417.IsReaderInitialization = true;
                gen.Save($"{path}ExtPDF417MetaReaderInitialization.png", BarCodeImageFormat.Png);
            }

            //try to recognize Pdf417 Reader Initialization
            Console.WriteLine("ReadExtPDF417Meta: Reader Initialization");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtPDF417MetaReaderInitialization.png", DecodeType.Pdf417))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"IsReaderInitialization:{result.Extended.Pdf417.IsReaderInitialization}");
                }
            }

            //generate MacroPdf417 with Linked state
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MicroPdf417, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.Pdf417.IsLinked = true;
                gen.Save($"{path}ExtPDF417MetaLinked.png", BarCodeImageFormat.Png);
            }

            //try to recognize Pdf417 Linked state
            Console.WriteLine("ReadExtPDF417Meta: Linked state");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtPDF417MetaLinked.png", DecodeType.MicroPdf417))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"IsLinked:{result.Extended.Pdf417.IsLinked}");
                }
            }

            //generate MacroPdf417 with Code128 Emulation state
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MicroPdf417, "Aspose.Barcode"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.Pdf417.IsCode128Emulation = true;
                gen.Save($"{path}ExtPDF417MetaCode128Emulation.png", BarCodeImageFormat.Png);
            }

            //try to recognize Pdf417 Linked state
            Console.WriteLine("ReadExtPDF417Meta: Code128 Emulation");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtPDF417MetaCode128Emulation.png", DecodeType.MicroPdf417))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"IsCode128Emulation:{result.Extended.Pdf417.IsCode128Emulation}");
                }
            }
        }
	}
}