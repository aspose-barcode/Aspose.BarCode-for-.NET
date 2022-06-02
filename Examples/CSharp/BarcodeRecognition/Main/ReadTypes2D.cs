//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadTypes2D : ReadMainBase
    {
		public static void Run()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string path = GetReadFolder();
            using (BarCodeReader reader = new BarCodeReader($"{path}multiple_codes.png", DecodeType.Types2D))
            {
                Console.WriteLine("ReadTypes2D:");
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}