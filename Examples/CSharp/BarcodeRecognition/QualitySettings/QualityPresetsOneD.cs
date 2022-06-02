//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class QualityPresetsOneD : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("QualityPresetsOneD:");

            //recognize image with QualitySettings NormalQuality
            Console.WriteLine("QualitySettings: NormalQuality");
            using (BarCodeReader read = new BarCodeReader($"{path}many_code128.png", DecodeType.Code128))
            {
                read.QualitySettings = QualitySettings.NormalQuality;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with QualitySettings HighQualityDetection
            Console.WriteLine("QualitySettings: HighQualityDetection");
            using (BarCodeReader read = new BarCodeReader($"{path}many_code128.png", DecodeType.Code128))
            {
                read.QualitySettings = QualitySettings.HighQualityDetection;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with QualitySettings MaxQualityDetection
            Console.WriteLine("QualitySettings: MaxQualityDetection");
            using (BarCodeReader read = new BarCodeReader($"{path}many_code128.png", DecodeType.Code128))
            {
                read.QualitySettings = QualitySettings.MaxQualityDetection;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}