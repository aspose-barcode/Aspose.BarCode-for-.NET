//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class WhiteSpotsRemoving : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();
            
            Console.WriteLine("WhiteSpotsRemoving:");

            //recognize image with AllowWhiteSpotsRemoving false
            Console.WriteLine("AllowWhiteSpotsRemoving: false");
            using (BarCodeReader read = new BarCodeReader($"{path}code128_whitespots.png", DecodeType.Code128))
            {
                read.QualitySettings.AllowWhiteSpotsRemoving = false;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with AllowWhiteSpotsRemoving true
            Console.WriteLine("AllowWhiteSpotsRemoving: true");
            using (BarCodeReader read = new BarCodeReader($"{path}code128_whitespots.png", DecodeType.Code128))
            {
                read.QualitySettings.AllowWhiteSpotsRemoving = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}