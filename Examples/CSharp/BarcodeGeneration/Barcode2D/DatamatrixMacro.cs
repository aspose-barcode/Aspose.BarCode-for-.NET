//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DatamatrixMacro : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DatamatrixMacro:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "ASPOSE");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            //set macro character to 05
            gen.Parameters.Barcode.DataMatrix.MacroCharacters = MacroCharacter.Macro05;
            gen.Save($"{path}DatamatrixMacro.png", BarCodeImageFormat.Png);

            //try to recognize it
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.DataMatrix);
            foreach (BarCodeResult result in read.ReadBarCodes())
                Console.WriteLine("DatamatrixMacro:" + result.CodeText);
        }
	}
}