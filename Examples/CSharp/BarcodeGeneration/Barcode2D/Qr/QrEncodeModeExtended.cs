//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrEncodeModeExtended : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QrEncodeModeExtended:");

            //generate extended codetext
            QrExtCodetextBuilder lTextBuilder = new QrExtCodetextBuilder();
            lTextBuilder.AddECICodetext(ECIEncodings.Win1251, "Aspose");
            lTextBuilder.AddECICodetext(ECIEncodings.UTF8, "常に先");
            lTextBuilder.AddECICodetext(ECIEncodings.UTF16BE, "を行く");
            lTextBuilder.AddPlainCodetext(@"!!!");

            //generate barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, lTextBuilder.GetExtendedCodetext()))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                Console.OutputEncoding = Encoding.Unicode;
                //set encode mode to Extended
                gen.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.Extended;
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Extended mode";
                gen.Save($"{path}QrEncodeModeExtended.png", BarCodeImageFormat.Png);

                //try to recognize it
                using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.QR))
                {
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                        Console.WriteLine("QrEncodeModeExtended:" + result.CodeText);
                }
            }
        }
	}
}