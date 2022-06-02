//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class MedianSmoothing : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("MedianSmoothing:");

            //recognize image with AllowMedianSmoothing false
            Console.WriteLine("AllowMedianSmoothing: false");
            using (BarCodeReader read = new BarCodeReader($"{path}datamatrix_noised.png", DecodeType.DataMatrix))
            {
                read.QualitySettings.AllowMedianSmoothing = false;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with AllowMedianSmoothing true
            Console.WriteLine("AllowMedianSmoothing: true");
            using (BarCodeReader read = new BarCodeReader($"{path}datamatrix_noised.png", DecodeType.DataMatrix))
            {
                read.QualitySettings.AllowMedianSmoothing = true;
                read.QualitySettings.MedianSmoothingWindowSize = 4;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}