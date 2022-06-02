//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class QualityPresetsMain : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("QualityPresetsMain:");

            //recognize image with QualitySettings HighPerformance
            Console.WriteLine("QualitySettings: HighPerformance");
            using (BarCodeReader read = new BarCodeReader($"{path}barcodes_different_quality.png", DecodeType.Code128, 
                DecodeType.Code39Extended, DecodeType.Planet, DecodeType.QR, DecodeType.MicroQR, DecodeType.Pdf417, DecodeType.DataMatrix, DecodeType.Aztec))
            {
                read.QualitySettings = QualitySettings.HighPerformance;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with QualitySettings NormalQuality
            Console.WriteLine("QualitySettings: NormalQuality");
            using (BarCodeReader read = new BarCodeReader($"{path}barcodes_different_quality.png", DecodeType.Code128,
                DecodeType.Code39Extended, DecodeType.Planet, DecodeType.QR, DecodeType.MicroQR, DecodeType.Pdf417, DecodeType.DataMatrix, DecodeType.Aztec))
            {
                read.QualitySettings = QualitySettings.NormalQuality;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with QualitySettings HighQuality
            Console.WriteLine("QualitySettings: HighQuality");
            using (BarCodeReader read = new BarCodeReader($"{path}barcodes_different_quality.png", DecodeType.Code128,
                DecodeType.Code39Extended, DecodeType.Planet, DecodeType.QR, DecodeType.MicroQR, DecodeType.Pdf417, DecodeType.DataMatrix, DecodeType.Aztec))
            {
                read.QualitySettings = QualitySettings.HighQuality;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}