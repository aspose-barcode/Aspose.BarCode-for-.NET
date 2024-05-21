//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrEncodeModeBinary : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QrEncodeModeBinary:");

            byte[] encodedArr = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 };

            //encode in QR code
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                //set encode mode to Binary
                gen.SetCodeText(encodedArr);
                gen.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.Binary;
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Binary mode";
                gen.Save($"{path}QrEncodeModeBinary.png", BarCodeImageFormat.Png);

                //try to recognize
                using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.QR))
                {
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                        Console.WriteLine("QrEncodeModeBinary:" + BitConverter.ToString(result.CodeBytes));
                }
            }
        }
	}
}