//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtDotCodeMeta : ReadExtendedBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.OutputEncoding = Encoding.Unicode;

            //generate DotCode with metadata
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DotCode, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Parameters.Barcode.DotCode.IsReaderInitialization = true;
                gen.Parameters.Barcode.DotCode.DotCodeStructuredAppendModeBarcodesCount = 4;
                gen.Parameters.Barcode.DotCode.DotCodeStructuredAppendModeBarcodeId = 2;

                gen.Save($"{path}ExtDotCodeMeta.png", BarCodeImageFormat.Png);
            }

            //try to recognize DotCode metadata
            Console.WriteLine("ReadExtDotCodeMeta:");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtDotCodeMeta.png", DecodeType.DotCode))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"DotCodeIsReaderInitialization:{result.Extended.DotCode.DotCodeIsReaderInitialization}");
                    Console.WriteLine($"DotCodeStructuredAppendModeBarcodesCount:{result.Extended.DotCode.DotCodeStructuredAppendModeBarcodesCount}");
                    Console.WriteLine($"DotCodeStructuredAppendModeBarcodeId:{result.Extended.DotCode.DotCodeStructuredAppendModeBarcodeId}");
                }
            }
        }
    }
}