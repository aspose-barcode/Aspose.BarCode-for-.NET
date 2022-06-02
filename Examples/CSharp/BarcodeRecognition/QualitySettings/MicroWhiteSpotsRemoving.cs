//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class MicroWhiteSpotsRemoving : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("MicroWhiteSpotsRemoving:");

            //recognize image with AllowMicroWhiteSpotsRemoving false
            Console.WriteLine("AllowMicroWhiteSpotsRemoving: false");
            using (BarCodeReader read = new BarCodeReader($"{path}planet_noised.png", DecodeType.Planet))
            {
                read.QualitySettings.AllowMicroWhiteSpotsRemoving = false;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with AllowMicroWhiteSpotsRemoving true
            Console.WriteLine("AllowMicroWhiteSpotsRemoving: true");
            using (BarCodeReader read = new BarCodeReader($"{path}planet_noised.png", DecodeType.Planet))
            {
                read.QualitySettings.AllowMicroWhiteSpotsRemoving = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}