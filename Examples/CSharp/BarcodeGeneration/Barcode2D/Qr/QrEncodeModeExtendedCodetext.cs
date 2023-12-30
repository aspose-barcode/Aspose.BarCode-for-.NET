//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrEncodeModeExtendedCodetext : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QrEncodeModeExtendedCodetext:");

            //generate extended codetext
            QrExtCodetextBuilder lTextBuilder = new QrExtCodetextBuilder();
            lTextBuilder.AddECICodetext(ECIEncodings.Win1251, "Aspose");
            lTextBuilder.AddECICodetext(ECIEncodings.UTF8, "常に先");
            lTextBuilder.AddECICodetext(ECIEncodings.UTF16BE, "を行く");
            lTextBuilder.AddPlainCodetext(@"!!!");
            //generate barcode
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, lTextBuilder.GetExtendedCodetext());
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            Console.OutputEncoding = Encoding.Unicode;
            //set encode mode to ExtendedCodetext
            gen.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.ExtendedCodetext;
            gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "ExtendedCodetext mode";
            gen.Save($"{path}QrEncodeModeExtendedCodetext.png", BarCodeImageFormat.Png);
            //try to recognize it
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.QR);
            foreach (BarCodeResult result in read.ReadBarCodes())
                Console.WriteLine("QrEncodeModeExtendedCodetext:" + result.CodeText);
        }
	}
}