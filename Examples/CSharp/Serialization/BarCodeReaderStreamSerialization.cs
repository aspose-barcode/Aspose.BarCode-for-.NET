//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Serialization
{
    internal class BarCodeReaderStreamSerialization : SerializationBase
    {
		public static void Run()
        {
            string path = GetFolder();
            string recpath = GetReaderFolder();
            System.Console.WriteLine("BarCodeReaderStreamSerialization:");


            //stream 
            MemoryStream ms = new MemoryStream();

            //init barcode reader
            using (BarCodeReader read = new BarCodeReader())
            {
                read.SetBarCodeReadType(DecodeType.Pdf417);
                read.BarcodeSettings.StripFNC = true;
                read.QualitySettings.MedianSmoothingWindowSize = 5;
                ////serialize BarCodeReader to stream
                read.ExportToXml(ms);
                ms.Position = 0;
            }

            //load BarCodeReader from file
            Console.WriteLine("BarCodeReaderStreamSerialization:");
            using (BarCodeReader read = BarCodeReader.ImportFromXml(ms))
            {
                //set the recognized file because it is not stored
                read.SetBarCodeImage($"{recpath}many_pdf417.png");
                //initialized data
                Console.WriteLine($"StripFNC:{read.BarcodeSettings.StripFNC}");
                Console.WriteLine($"MedianSmoothingWindowSize:{read.QualitySettings.MedianSmoothingWindowSize}");
                //read
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}