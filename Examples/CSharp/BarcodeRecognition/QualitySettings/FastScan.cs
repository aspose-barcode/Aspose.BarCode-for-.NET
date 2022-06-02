//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Diagnostics;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class FastScan : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.WriteLine("FastScan:");

            //recognize image with FastScan options disabled
            Console.WriteLine("FastScan: disabled");
            using (BarCodeReader read = new BarCodeReader($"{path}code128_hq.png", DecodeType.Code128))
            {
                read.QualitySettings.FastScanOnly = false;
                read.QualitySettings.AllowOneDFastBarcodesDetector = false;
                Stopwatch watch = new Stopwatch();
                watch.Start();
                read.ReadBarCodes();
                watch.Stop();
                Console.WriteLine($"Barcodes read: {read.FoundCount}, Recognition time:{(int)watch.ElapsedMilliseconds} ms");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
            
            //recognize image with FastScan options enabled
            Console.WriteLine("FastScan: enabled");
            using (BarCodeReader read = new BarCodeReader($"{path}code128_hq.png", DecodeType.Code128))
            {
                read.QualitySettings.FastScanOnly = true;
                read.QualitySettings.AllowOneDFastBarcodesDetector = true;
                Stopwatch watch = new Stopwatch();
                watch.Start();
                read.ReadBarCodes();
                watch.Stop();
                Console.WriteLine($"Barcodes read: {read.FoundCount}, Recognition time:{(int)watch.ElapsedMilliseconds} ms");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}