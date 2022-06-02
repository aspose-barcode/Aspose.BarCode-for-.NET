//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class OneDWipedBarsRestoration : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("OneDWipedBarsRestoration:");

            //recognize image with AllowQRMicroQrRestoration and CheckMore1DVariants false
            Console.WriteLine("AllowQRMicroQrRestoration and CheckMore1DVariants: false");
            using (BarCodeReader read = new BarCodeReader($"{path}code128_wipedbars.png", DecodeType.Code128))
            {
                read.QualitySettings.AllowOneDWipedBarsRestoration = false;
                read.QualitySettings.CheckMore1DVariants = false;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with AllowQRMicroQrRestoration and CheckMore1DVariants true
            Console.WriteLine("AllowQRMicroQrRestoration and CheckMore1DVariants: true");
            using (BarCodeReader read = new BarCodeReader($"{path}code128_wipedbars.png", DecodeType.Code128))
            {
                read.QualitySettings.AllowOneDWipedBarsRestoration = true;
                read.QualitySettings.CheckMore1DVariants = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}