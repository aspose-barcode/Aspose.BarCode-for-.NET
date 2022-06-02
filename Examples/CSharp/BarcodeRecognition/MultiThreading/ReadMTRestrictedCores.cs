//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Threading;
using System.Diagnostics;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadMTRestrictedCores : ReadMultiThreadingBase
    {
		public static void Run()
        {
            string path = GetFolder();

            Console.WriteLine("ReadMTRestrictedCores:");

            //allowed cores
            int AllowedCores = 2;

            //Init ThreadPool options
            int workerThreads;
            int completionPortThreads;
            ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
            ThreadPool.SetMaxThreads(Math.Max(AllowedCores * 4, workerThreads), completionPortThreads);
            ThreadPool.GetMinThreads(out workerThreads, out completionPortThreads);
            ThreadPool.SetMinThreads(Math.Max(AllowedCores * 4, workerThreads), completionPortThreads);

            //Set multi-threadeded all-cores recognition
            BarCodeReader.ProcessorSettings.UseAllCores = false;
            BarCodeReader.ProcessorSettings.UseOnlyThisCoresCount = AllowedCores;
            BarCodeReader.ProcessorSettings.MaxAdditionalAllowedThreads = AllowedCores;

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