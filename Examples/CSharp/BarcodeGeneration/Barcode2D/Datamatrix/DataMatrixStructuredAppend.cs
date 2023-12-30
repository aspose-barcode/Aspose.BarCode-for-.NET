//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;
#if NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_1_OR_GREATER
using Aspose.Drawing;
#else
using System.Drawing;
#endif

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DataMatrixStructuredAppend : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DataMatrixStructuredAppend:");

            using (BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.DataMatrix, "Aspose"))
            {
                generator.Parameters.Barcode.XDimension.Pixels = 4;
                //set DataMatrix strucutured append mode
                generator.Parameters.Barcode.DataMatrix.StructuredAppendBarcodeId = 3;
                generator.Parameters.Barcode.DataMatrix.StructuredAppendBarcodesCount = 5;
                generator.Parameters.Barcode.DataMatrix.StructuredAppendFileId = 150;
                Bitmap bitmap = generator.GenerateBarCodeImage();
                using (BarCodeReader reader = new BarCodeReader(bitmap, DecodeType.DataMatrix))
                {
                    reader.ReadBarCodes();
                    Console.WriteLine("Barcode ID: {0}", reader.FoundBarCodes[0].Extended.DataMatrix.StructuredAppendBarcodeId);
                    Console.WriteLine("Barcodes count: {0}", reader.FoundBarCodes[0].Extended.DataMatrix.StructuredAppendBarcodesCount);
                    Console.WriteLine("File ID: {0}", reader.FoundBarCodes[0].Extended.DataMatrix.StructuredAppendFileId);
                }
            }
        }
    }
}