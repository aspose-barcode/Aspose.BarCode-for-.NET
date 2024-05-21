//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DatamatrixEncodeModeExtended : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.WriteLine("DataMatrixExtended:");

            //create codetext
            DataMatrixExtCodetextBuilder codetextBuilder = new DataMatrixExtCodetextBuilder();
            codetextBuilder.AddECICodetext(ECIEncodings.UTF8, "犬Right狗");
            codetextBuilder.AddECICodetextWithEncodeMode(ECIEncodings.UTF8, DataMatrixEncodeMode.C40, "ABCDE");
            codetextBuilder.AddPlainCodetext("test");
            codetextBuilder.AddCodetextWithEncodeMode(DataMatrixEncodeMode.Text, "abcde");

            //generate codetext
            string codetext = codetextBuilder.GetExtendedCodetext();

            //generate DataMatrix
            using (var generator = new BarcodeGenerator(EncodeTypes.DataMatrix, codetext))
            {
                generator.Parameters.Barcode.XDimension.Pixels = 4;
                generator.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Extended mode";
                //set encode mode to Extended
                generator.Parameters.Barcode.DataMatrix.DataMatrixEncodeMode = DataMatrixEncodeMode.Extended;

                generator.Save($"{path}DataMatrixEncodeModeExtended.png", BarCodeImageFormat.Png);

                //try to recognize
                using (var reader = new BarCodeReader(generator.GenerateBarCodeImage(), DecodeType.DataMatrix))
                {
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                        Console.WriteLine("DataMatrixEncodeModeExtended:" + result.CodeText);
                }
            }
        }
	}
}