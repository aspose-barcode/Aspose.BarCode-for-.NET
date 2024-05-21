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
    internal class DataMatrixEncodeModeAuto : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DataMatrixEncodeModeAuto:");

            using (BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.DataMatrix, "Aspose常に先を行く"))
            {
                generator.Parameters.Barcode.XDimension.Pixels = 4;
                //set encode mode to Auto
                generator.Parameters.Barcode.DataMatrix.DataMatrixEncodeMode = DataMatrixEncodeMode.Auto;
                generator.Save($"{path}DataMatrixEncodeModeAuto.png", BarCodeImageFormat.Png);

                using (BarCodeReader reader = new BarCodeReader(generator.GenerateBarCodeImage(), DecodeType.DataMatrix))
                {
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                    {
                        Console.WriteLine($"CodeType:{result.CodeTypeName}");
                        Console.WriteLine($"CodeText:{result.CodeText}");
                    }
                }
            }
        }
	}
}