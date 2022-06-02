//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class RegularImage : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("RegularImage:");

            //recognize image with AllowRegularImage false
            Console.WriteLine("AllowRegularImage: false");
            using (BarCodeReader read = new BarCodeReader($"{path}aztec_regular_inverse.png", DecodeType.Aztec))
            {
                read.QualitySettings = QualitySettings.HighPerformance;
                read.QualitySettings.AllowRegularImage = false;
                read.QualitySettings.AllowInvertImage = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with AllowRegularImage true
            Console.WriteLine("AllowRegularImage: true");
            using (BarCodeReader read = new BarCodeReader($"{path}aztec_regular_inverse.png", DecodeType.Aztec))
            {
                read.QualitySettings = QualitySettings.HighPerformance;
                read.QualitySettings.AllowRegularImage = true;
                read.QualitySettings.AllowInvertImage = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}