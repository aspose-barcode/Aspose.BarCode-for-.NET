//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class QRMicroQrRestoration : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("QRMicroQrRestoration:");

            //recognize image with AllowQRMicroQrRestoration false
            Console.WriteLine("AllowQRMicroQrRestoration: false");
            using (BarCodeReader read = new BarCodeReader($"{path}microqr_3d_distorted.png", DecodeType.MicroQR))
            {
                read.QualitySettings.AllowQRMicroQrRestoration = false;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with AllowQRMicroQrRestoration true
            Console.WriteLine("AllowQRMicroQrRestoration: true");
            using (BarCodeReader read = new BarCodeReader($"{path}microqr_3d_distorted.png", DecodeType.MicroQR))
            {
                read.QualitySettings.AllowQRMicroQrRestoration = true;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}