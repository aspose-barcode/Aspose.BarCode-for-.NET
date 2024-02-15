//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadIncorrectBarcodes : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("ReadIncorrectBarcodes:");
            //recognize image with disabled AllowIncorrectBarcodes
            Console.WriteLine("AllowIncorrectBarcodes: false");
            using (BarCodeReader read = new BarCodeReader($"{path}pdf417_qr_corrupted.png", DecodeType.QR, DecodeType.Pdf417))
            {
                read.QualitySettings.AllowIncorrectBarcodes = false;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with enambled AllowIncorrectBarcodes
            Console.WriteLine("AllowIncorrectBarcodes: true");
            using (BarCodeReader read = new BarCodeReader($"{path}pdf417_qr_corrupted.png", DecodeType.QR, DecodeType.Pdf417))
            {
                read.QualitySettings.AllowIncorrectBarcodes = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}