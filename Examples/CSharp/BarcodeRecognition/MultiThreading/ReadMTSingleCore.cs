//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Diagnostics;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadMTSingleCore : ReadMultiThreadingBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("ReadMTSingleCore:");

            //Set single-threaded recognition
            BarCodeReader.ProcessorSettings.UseAllCores = false;
            BarCodeReader.ProcessorSettings.UseOnlyThisCoresCount = 1;
            BarCodeReader.ProcessorSettings.MaxAdditionalAllowedThreads = 0;

            //recognize image
            using (BarCodeReader read = new BarCodeReader($"{path}many_pdf417.png", DecodeType.Pdf417))
            {
                Stopwatch watch = Stopwatch.StartNew();
                read.ReadBarCodes();
                watch.Stop();
                Console.WriteLine($"Barcodes read: {read.FoundCount}, Recognition time:{(int)watch.ElapsedMilliseconds} ms");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

        }
	}
}