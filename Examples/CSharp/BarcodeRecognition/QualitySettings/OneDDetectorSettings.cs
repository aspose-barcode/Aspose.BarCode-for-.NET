//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class OneDDetectorSettings : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("OneDDetectorSettings:");

            //recognize image with DetectorSettings HighPerformance
            Console.WriteLine("DetectorSettings: HighPerformance");
            using (BarCodeReader read = new BarCodeReader($"{path}many_code128.png", DecodeType.Code128))
            {
                read.QualitySettings.DetectorSettings = BarcodeSvmDetectorSettings.HighPerformance;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with DetectorSettings MaxQuality
            Console.WriteLine("DetectorSettings: MaxQuality");
            using (BarCodeReader read = new BarCodeReader($"{path}many_code128.png", DecodeType.Code128))
            {
                read.QualitySettings.DetectorSettings = BarcodeSvmDetectorSettings.MaxQuality;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}