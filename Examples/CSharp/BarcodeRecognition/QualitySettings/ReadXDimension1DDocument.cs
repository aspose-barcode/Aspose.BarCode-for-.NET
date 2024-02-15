//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadXDimension1DDocument : ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("ReadXDimension1DDocument:");
            //recognize image with XDimension Normal
            Console.WriteLine("XDimensionMode: Normal");
            using (BarCodeReader read = new BarCodeReader($"{path}many_code128.png", DecodeType.Code128))
            {
                read.QualitySettings.XDimension = XDimensionMode.Normal;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }


            //recognize image with XDimension 
            Console.WriteLine("XDimensionMode: Small");
            using (BarCodeReader read = new BarCodeReader($"{path}many_code128.png", DecodeType.Code128))
            {
                read.QualitySettings.XDimension = XDimensionMode.Small;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with XDimension 
            Console.WriteLine("XDimensionMode: UseMinimalXDimension");
            using (BarCodeReader read = new BarCodeReader($"{path}many_code128.png", DecodeType.Code128))
            {
                read.QualitySettings.XDimension = XDimensionMode.UseMinimalXDimension;
                read.QualitySettings.MinimalXDimension = 1;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}