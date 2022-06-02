//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class DecreasedImage : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("DecreasedImage:");

            //recognize image with AllowDecreasedImage false
            Console.WriteLine("AllowDecreasedImage: false");
            using (BarCodeReader read = new BarCodeReader($"{path}datamatrix_waved.png", DecodeType.DataMatrix))
            {
                read.QualitySettings.AllowDecreasedImage = false;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with AllowDecreasedImage true
            Console.WriteLine("AllowDecreasedImage: true");
            using (BarCodeReader read = new BarCodeReader($"{path}datamatrix_waved.png", DecodeType.DataMatrix))
            {
                read.QualitySettings.AllowDecreasedImage = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}