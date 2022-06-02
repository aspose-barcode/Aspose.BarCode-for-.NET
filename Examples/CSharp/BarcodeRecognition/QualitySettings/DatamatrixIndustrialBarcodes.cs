//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class DatamatrixIndustrialBarcodes : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("DatamatrixIndustrialBarcodes:");

            //recognize image with AllowDatamatrixIndustrialBarcodes false
            Console.WriteLine("AllowDatamatrixIndustrialBarcodes: false");
            using (BarCodeReader read = new BarCodeReader($"{path}datamatrix_industrial.png", DecodeType.DataMatrix))
            {
                read.QualitySettings.AllowDatamatrixIndustrialBarcodes = false;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with AllowDatamatrixIndustrialBarcodes true
            Console.WriteLine("AllowDatamatrixIndustrialBarcodes: true");
            using (BarCodeReader read = new BarCodeReader($"{path}datamatrix_industrial.png", DecodeType.DataMatrix))
            {
                read.QualitySettings.AllowDatamatrixIndustrialBarcodes = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
    }
}