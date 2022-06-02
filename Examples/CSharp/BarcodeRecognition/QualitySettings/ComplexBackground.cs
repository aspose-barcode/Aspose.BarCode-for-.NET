//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ComplexBackground : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("ComplexBackground:");

            //recognize image with AllowComplexBackground false
            Console.WriteLine("AllowComplexBackground: false");
            using (BarCodeReader read = new BarCodeReader($"{path}qr_color.png", DecodeType.QR))
            {
                read.QualitySettings.AllowComplexBackground = false;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
            
            //recognize image with AllowComplexBackground true
            Console.WriteLine("AllowComplexBackground: true");
            using (BarCodeReader read = new BarCodeReader($"{path}qr_color.png", DecodeType.QR))
            {
                read.QualitySettings.AllowComplexBackground = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}