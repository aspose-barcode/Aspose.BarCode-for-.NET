//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrStructuredAppend : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QrStructuredAppend:");

            Console.OutputEncoding = Encoding.Unicode;
            //messages
            string firstMessage = "Aspose";
            string secondMessage = "常に先を行く";
            //calculate parity byte
            byte parity = 0;
            foreach (char val in firstMessage.ToCharArray())
                parity ^= (val <= 255) ? (byte)val : (byte)((byte)val ^ (byte)((int)val >> 8));
            foreach (char val in secondMessage.ToCharArray())
                parity ^= (val <= 255) ? (byte)val : (byte)((byte)val ^ (byte)((int)val >> 8));

            //generate first barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, firstMessage))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.ECIEncoding;
                gen.Parameters.Barcode.QR.QrECIEncoding = ECIEncodings.UTF8;
                gen.Parameters.Barcode.QR.StructuredAppend.ParityByte = parity;
                gen.Parameters.Barcode.QR.StructuredAppend.TotalCount = 2;
                gen.Parameters.Barcode.QR.StructuredAppend.SequenceIndicator = 0;
                gen.Save($"{path}QrStructuredAppendFirst.png", BarCodeImageFormat.Png);
                //try to recognize it
                using (BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.QR))
                {
                    foreach (BarCodeResult result in read.ReadBarCodes())
                        Console.WriteLine($"QrStructuredAppend: Count:{result.Extended.QR.QRStructuredAppendModeBarCodesQuantity} " +
                            $"Index: {result.Extended.QR.QRStructuredAppendModeBarCodeIndex} Parity:{result.Extended.QR.QRStructuredAppendModeParityData.ToString()} " +
                            $"Codetext: {result.CodeText}");
                }
            }

            //generate second barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, secondMessage)) { 
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.ECIEncoding;
                gen.Parameters.Barcode.QR.QrECIEncoding = ECIEncodings.UTF8;
                gen.Parameters.Barcode.QR.StructuredAppend.ParityByte = parity;
                gen.Parameters.Barcode.QR.StructuredAppend.TotalCount = 2;
                gen.Parameters.Barcode.QR.StructuredAppend.SequenceIndicator = 1;
                gen.Save($"{path}QrStructuredAppendSecond.png", BarCodeImageFormat.Png);
                //try to recognize it
                using (BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.QR))
                {
                    foreach (BarCodeResult result in read.ReadBarCodes())
                        Console.WriteLine($"QrStructuredAppend: Count:{result.Extended.QR.QRStructuredAppendModeBarCodesQuantity} " +
                            $"Index: {result.Extended.QR.QRStructuredAppendModeBarCodeIndex} Parity:{result.Extended.QR.QRStructuredAppendModeParityData.ToString()} " +
                            $"Codetext: {result.CodeText}");
                }
            }
        }
    }
}