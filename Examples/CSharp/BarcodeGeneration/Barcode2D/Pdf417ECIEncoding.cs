//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Pdf417ECIEncoding  : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Pdf417ECIEncoding:");

            Console.OutputEncoding = Encoding.Unicode;
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Aspose常に先を行く");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Pdf417.Columns = 3;
            //set UTF8 ECI encoding
            gen.Parameters.Barcode.Pdf417.Pdf417ECIEncoding = ECIEncodings.UTF8;
            gen.Save($"{path}Pdf417ECIEncoding.png", BarCodeImageFormat.Png);
            //try to recognize it
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.Pdf417);
            foreach (BarCodeResult result in read.ReadBarCodes())
                Console.WriteLine("Pdf417ECIEncoding:" + result.CodeText);
        }
	}
}