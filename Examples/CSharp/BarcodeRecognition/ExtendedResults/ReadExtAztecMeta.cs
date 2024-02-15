//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtAztecMeta : ReadExtendedBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.OutputEncoding = Encoding.Unicode;

            //generate Aztec with metadata
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Parameters.Barcode.Aztec.AztecSymbolMode = AztecSymbolMode.FullRange;
                gen.Parameters.Barcode.Aztec.IsReaderInitialization = true;
                gen.Parameters.Barcode.Aztec.StructuredAppendBarcodeId = 2;
                gen.Parameters.Barcode.Aztec.StructuredAppendBarcodesCount = 4;
                gen.Parameters.Barcode.Aztec.StructuredAppendFileId = "File01";

                gen.Save($"{path}ExtAztecMeta.png", BarCodeImageFormat.Png);
            }

            //try to recognize Aztec metadata
            Console.WriteLine("ReadExtAztecMeta:");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtAztecMeta.png", DecodeType.Aztec))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"IsReaderInitialization:{result.Extended.Aztec.IsReaderInitialization}");
                    Console.WriteLine($"StructuredAppendBarcodeId:{result.Extended.Aztec.StructuredAppendBarcodeId}");
                    Console.WriteLine($"StructuredAppendBarcodesCount:{result.Extended.Aztec.StructuredAppendBarcodesCount}");
                    Console.WriteLine($"StructuredAppendFileId:{result.Extended.Aztec.StructuredAppendFileId}");
                }
            }
        }
    }
}