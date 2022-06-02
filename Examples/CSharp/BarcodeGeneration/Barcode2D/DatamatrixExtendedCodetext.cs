//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DatamatrixExtendedCodetext : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DatamatrixExtendedCodetext:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            //set encode mode to ExtendedCodetext
            gen.Parameters.Barcode.DataMatrix.DataMatrixEncodeMode = DataMatrixEncodeMode.ExtendedCodetext;
            //set codetext with multiple encodings (ansix12 encoding)(Text)(ascii encoding)(Text)(edifact encoding)(Text)
            gen.CodeText = @"\ansix12:ANSIX12TEXT\ascii:backslash must be \\ doubled\edifact:EDIFACT-ENCODED-TEXT";
            gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Extended Codetext";
            gen.Save($"{path}DatamatrixExtendedCodetext.png", BarCodeImageFormat.Png);
            
            //try to recognize
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.DataMatrix);
            foreach (BarCodeResult result in read.ReadBarCodes())
                Console.WriteLine("DatamatrixExtendedCodetext:" + result.CodeText);
        }
	}
}