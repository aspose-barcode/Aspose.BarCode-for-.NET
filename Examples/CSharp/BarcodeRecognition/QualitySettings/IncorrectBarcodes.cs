//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class IncorrectBarcodes : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("IncorrectBarcodes:");

            //recognize image with AllowIncorrectBarcodes false
            Console.WriteLine("AllowIncorrectBarcodes: false");
            using (BarCodeReader read = new BarCodeReader($"{path}pdf417_qr_corrupted.png", DecodeType.Pdf417, DecodeType.QR))
            {
                read.QualitySettings.AllowIncorrectBarcodes = false;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
            
            //recognize image with AllowIncorrectBarcodes true
            Console.WriteLine("AllowIncorrectBarcodes: true");
            using (BarCodeReader read = new BarCodeReader($"{path}pdf417_qr_corrupted.png", DecodeType.Pdf417, DecodeType.QR))
            {
                read.QualitySettings.AllowIncorrectBarcodes = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}