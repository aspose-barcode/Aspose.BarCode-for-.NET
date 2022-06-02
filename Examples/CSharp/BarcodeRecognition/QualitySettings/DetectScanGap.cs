//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class DetectScanGap : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("DetectScanGap:");

            //recognize image with AllowDetectScanGap true
            Console.WriteLine("AllowDetectScanGap: true");
            using (BarCodeReader read = new BarCodeReader($"{path}code128_big_and_small.png", DecodeType.Code128))
            {
                read.QualitySettings.AllowDetectScanGap = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with AllowDetectScanGap false
            Console.WriteLine("AllowDetectScanGap: false");
            using (BarCodeReader read = new BarCodeReader($"{path}code128_big_and_small.png", DecodeType.Code128))
            {
                read.QualitySettings.AllowDetectScanGap = false;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
    }
}