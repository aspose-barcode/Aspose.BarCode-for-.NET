//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrEncodeModeAuto : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QrEncodeModeAuto:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "Aspose常に先を行く");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            Console.OutputEncoding = Encoding.Unicode;
            //set encode mode to Auto
            gen.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.Auto;
            //set CodeText encoding to UTF8
            gen.Parameters.Barcode.QR.CodeTextEncoding = Encoding.UTF8;
            gen.Save($"{path}QrEncodeModeAuto.png", BarCodeImageFormat.Png);
            //try to recognize it
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.QR);
            read.BarcodeSettings.DetectEncoding = true;
            foreach (BarCodeResult result in read.ReadBarCodes())
                Console.WriteLine("QrEncodeModeAuto:" + result.CodeText);
        }
	}
}