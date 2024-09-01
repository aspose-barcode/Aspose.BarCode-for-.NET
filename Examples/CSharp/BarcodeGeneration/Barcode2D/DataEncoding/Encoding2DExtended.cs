//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Encoding2DExtended: TwoDEncodingBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.WriteLine("Encoding2DExtended:");

            //generate extended codetext
            QrExtCodetextBuilder textBuilder = new QrExtCodetextBuilder();
            textBuilder.AddECICodetext(ECIEncodings.Win1251, "Слово");
            textBuilder.AddECICodetext(ECIEncodings.UTF8, "常に先");
            textBuilder.AddECICodetext(ECIEncodings.UTF16BE, "を行く");
            textBuilder.AddPlainCodetext(@"Aspose");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, textBuilder.GetExtendedCodetext()))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 8;
                gen.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.Extended;
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Extended mode";
                gen.Save($"{path}Encoding2DExtended.png", BarCodeImageFormat.Png);

                using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.QR))
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                        Console.WriteLine($"CodeText:{result.CodeText}");
            }
        }
    }
}