//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtMaxiCodeMeta : ReadExtendedBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.OutputEncoding = Encoding.Unicode;

            //generate MaxiCode with metadata
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MaxiCode, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.MaxiCode.MaxiCodeMode = MaxiCodeMode.Mode5;
                gen.Parameters.Barcode.MaxiCode.MaxiCodeStructuredAppendModeBarcodesCount = 4;
                gen.Parameters.Barcode.MaxiCode.MaxiCodeStructuredAppendModeBarcodeId = 2;

                gen.Save($"{path}ExtMaxiCodeMeta.png", BarCodeImageFormat.Png);
            }

            //try to recognize MaxiCode metadata
            Console.WriteLine("ReadExtMaxiCodeMeta:");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtMaxiCodeMeta.png", DecodeType.MaxiCode))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"MaxiCodeMode:{result.Extended.MaxiCode.MaxiCodeMode.ToString()}");
                    Console.WriteLine($"MaxiCodeStructuredAppendModeBarcodesCount:{result.Extended.MaxiCode.MaxiCodeStructuredAppendModeBarcodesCount}");
                    Console.WriteLine($"MaxiCodeStructuredAppendModeBarcodeId:{result.Extended.MaxiCode.MaxiCodeStructuredAppendModeBarcodeId}");
                }
            }
        }
    }
}