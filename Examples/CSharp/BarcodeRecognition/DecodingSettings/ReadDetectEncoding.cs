//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadDetectEncoding : ReadDecodingBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = Encoding.Unicode;

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "بالقمة Aspose"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Parameters.Barcode.QR.CodeTextEncoding = Encoding.UTF8;
                gen.Save($"{path}QRDetectEncoding.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("ReadDetectEncoding:");
            //recognize image with DetectEncoding true
            Console.WriteLine("DetectEncoding: true");
            using (BarCodeReader read = new BarCodeReader($"{path}QRDetectEncoding.png", DecodeType.QR))
            {
                read.BarcodeSettings.DetectEncoding = true;
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
            }

            //recognize image with DetectEncoding false
            Console.WriteLine("DetectEncoding: false");
            using (BarCodeReader read = new BarCodeReader($"{path}QRDetectEncoding.png", DecodeType.QR))
            {
                read.BarcodeSettings.DetectEncoding = false;
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
            }
        }
    }
}