//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtDataMatrixMeta : ReadExtendedBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.OutputEncoding = Encoding.Unicode;

            //generate DataMatrix with Structured Append metadata
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Parameters.Barcode.DataMatrix.StructuredAppendBarcodesCount = 4;
                gen.Parameters.Barcode.DataMatrix.StructuredAppendBarcodeId = 2;
                gen.Parameters.Barcode.DataMatrix.StructuredAppendFileId = 4321;

                gen.Save($"{path}ExtDataMatrixMetaStructuredAppend.png", BarCodeImageFormat.Png);
            }

            //try to recognize DataMatrix metadata Structured Append
            Console.WriteLine("ReadExtDataMatrixMeta: Structured Append");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtDataMatrixMetaStructuredAppend.png", DecodeType.DataMatrix))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"StructuredAppendBarcodesCount:{result.Extended.DataMatrix.StructuredAppendBarcodesCount}");
                    Console.WriteLine($"StructuredAppendBarcodeId:{result.Extended.DataMatrix.StructuredAppendBarcodeId}");
                    Console.WriteLine($"StructuredAppendFileId:{result.Extended.DataMatrix.StructuredAppendFileId}");
                }
            }

            //generate DataMatrix with Reader Programming metadata
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Parameters.Barcode.DataMatrix.IsReaderProgramming = true;

                gen.Save($"{path}ExtDataMatrixMetaReaderProgramming.png", BarCodeImageFormat.Png);
            }

            //try to recognize DataMatrix metadata Reader Programming
            Console.WriteLine("ReadExtDataMatrixMeta: Reader Programming");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtDataMatrixMetaReaderProgramming.png", DecodeType.DataMatrix))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"IsReaderProgramming:{result.Extended.DataMatrix.IsReaderProgramming}");
                }
            }

        }
    }
}