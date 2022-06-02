//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DatamatrixEncodeModeCustom : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DatamatrixEncodeModeCustom:");

            Console.OutputEncoding = Encoding.Unicode;
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "Aspose常に先を行く");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            //set encode mode to Full
            gen.Parameters.Barcode.DataMatrix.DataMatrixEncodeMode = DataMatrixEncodeMode.Custom;
            gen.Parameters.Barcode.DataMatrix.CodeTextEncoding = Encoding.UTF8;
            gen.Save($"{path}DatamatrixEncodeModeCustom.png", BarCodeImageFormat.Png);
            
            //try to recognize it
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.DataMatrix);
            foreach (BarCodeResult result in read.ReadBarCodes())
                Console.WriteLine("DatamatrixEncodeModeCustom:" + result.GetCodeText(Encoding.UTF8));
        }
    }
}