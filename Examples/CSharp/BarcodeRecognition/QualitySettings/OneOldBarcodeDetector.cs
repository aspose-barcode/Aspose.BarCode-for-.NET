//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class OneOldBarcodeDetector : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("OneOldBarcodeDetector:");

            //recognize image with UseOldBarcodeDetector false
            Console.WriteLine("UseOldBarcodeDetector: false");
            using (BarCodeReader read = new BarCodeReader($"{path}many_code128.png", DecodeType.Code128))
            {
                read.QualitySettings.UseOldBarcodeDetector = false;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with UseOldBarcodeDetector true
            Console.WriteLine("UseOldBarcodeDetector: true");
            using (BarCodeReader read = new BarCodeReader($"{path}many_code128.png", DecodeType.Code128))
            {
                read.QualitySettings.UseOldBarcodeDetector = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}