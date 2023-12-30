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
    internal class DataMatrixReaderProgramming : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DataMatrixReaderProgramming:");

            using (BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.DataMatrix, "Aspose"))
            {
                generator.Parameters.Barcode.XDimension.Pixels = 4;
                //set flag that indicates that data is encoded for reader programming
                generator.Parameters.Barcode.DataMatrix.IsReaderProgramming = true;
                Bitmap bitmap = generator.GenerateBarCodeImage();

                using (BarCodeReader reader = new BarCodeReader(bitmap, DecodeType.DataMatrix))
                {
                    reader.ReadBarCodes();
                    Console.WriteLine("Is reader programming: {0}", reader.FoundBarCodes[0].Extended.DataMatrix.IsReaderProgramming);
                }
            }
        }
    }
}