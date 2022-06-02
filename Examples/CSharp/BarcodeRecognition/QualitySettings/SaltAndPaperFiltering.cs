//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class SaltAndPaperFiltering : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.WriteLine("SaltAndPaperFiltering:");

            //recognize image with AllowSaltAndPaperFiltering false
            Console.WriteLine("AllowSaltAndPaperFiltering: false");
            using (BarCodeReader read = new BarCodeReader($"{path}saltandpaper.png", DecodeType.Code39Standard, DecodeType.Code39Extended))
            {
                read.QualitySettings.AllowSaltAndPaperFiltering = false;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
            
            //recognize image with AllowSaltAndPaperFiltering true
            Console.WriteLine("AllowSaltAndPaperFiltering: true");
            using (BarCodeReader read = new BarCodeReader($"{path}saltandpaper.png", DecodeType.Code39Standard, DecodeType.Code39Extended))
            {
                read.QualitySettings.AllowSaltAndPaperFiltering = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}