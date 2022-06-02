//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecCodeTextEncoding : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecCodeTextEncoding:");

            Console.OutputEncoding = Encoding.Unicode;
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, "Aspose常に先を行く");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            //set UTF8 encoding
            gen.Parameters.Barcode.Aztec.CodeTextEncoding = Encoding.UTF8;
            gen.Save($"{path}AztecCodeTextEncoding.png", BarCodeImageFormat.Png);
            //try to recognize it
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.Aztec);
            foreach (BarCodeResult result in read.ReadBarCodes())
                Console.WriteLine("AztecCodeTextEncoding:" + result.GetCodeText(Encoding.UTF8));
        }
	}
}