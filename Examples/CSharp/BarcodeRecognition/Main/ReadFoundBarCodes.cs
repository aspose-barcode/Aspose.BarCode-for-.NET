//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadFoundBarCodes : ReadMainBase
    {
		public static void Run()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string path = GetReadFolder();
            using (BarCodeReader reader = new BarCodeReader($"{path}multiple_codes.png", DecodeType.Pdf417, DecodeType.DataMatrix, DecodeType.QR,
                DecodeType.Code39Extended, DecodeType.Code128, DecodeType.RM4SCC))
            {
                //now we read barcodes
                reader.ReadBarCodes();
                Console.WriteLine("ReadFoundBarCodes:");
                Console.WriteLine($"BarCodes count:{reader.FoundCount.ToString()}");
                foreach (BarCodeResult result in reader.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}