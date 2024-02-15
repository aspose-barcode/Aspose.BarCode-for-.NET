//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadComplexBackground : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("ReadComplexBackground :");
            //recognize image with Complex background mode Disabled
            Console.WriteLine("ComplexBackgroundMode: Disabled");
            using (BarCodeReader read = new BarCodeReader($"{path}qr_color.png", DecodeType.QR))
            {
                read.QualitySettings.ComplexBackground = ComplexBackgroundMode.Disabled;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with Complex background mode Enabled
            Console.WriteLine("ComplexBackgroundMode: Enabled");
            using (BarCodeReader read = new BarCodeReader($"{path}qr_color.png", DecodeType.QR))
            {
                read.QualitySettings.ComplexBackground = ComplexBackgroundMode.Enabled;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}