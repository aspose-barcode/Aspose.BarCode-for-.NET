//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtQuality : ReadExtendedBase
    {
		public static void Run()
        {
            string path = GetReadFolder();
            
            //recognize image
            Console.WriteLine("ReadExtQuality:");
            using (BarCodeReader read = new BarCodeReader($"{path}qr_code128.png", DecodeType.QR, DecodeType.Code128))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"Confidence:{result.Confidence.ToString()}");
                    Console.WriteLine($"ReadingQuality:{result.ReadingQuality.ToString()}");
                }
            }
        }
	}
}