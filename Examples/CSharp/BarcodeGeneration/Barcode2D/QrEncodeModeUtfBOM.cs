//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrEncodeModeUtfBOM : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QrEncodeModeUtfBOM:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "Aspose常に先を行く");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            Console.OutputEncoding = Encoding.Unicode;
            //set encode mode to UTF16BE with BOM
            gen.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.Utf16BEBOM;
            gen.Save($"{path}QrEncodeModeUtfBOM.png", BarCodeImageFormat.Png);
            //try to recognize it
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.QR);
            read.BarcodeSettings.DetectEncoding = true;
            foreach (BarCodeResult result in read.ReadBarCodes())
                Console.WriteLine("QrEncodeModeUtfBOM:" + result.CodeText);
        }
	}
}