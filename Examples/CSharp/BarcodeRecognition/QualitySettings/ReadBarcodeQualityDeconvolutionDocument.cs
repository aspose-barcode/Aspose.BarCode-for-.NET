//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadBarcodeQualityDeconvolutionDocument: ReadQualityBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("ReadBarcodeQualityDeconvolutionDocument:");
            //recognize image with BarcodeQualityMode High, DeconvolutionMode Fast
            Console.WriteLine("BarcodeQualityMode: High, DeconvolutionMode: Fast");
            using (BarCodeReader read = new BarCodeReader($"{path}manybarcodes_quality_deconvolution.png", DecodeType.Code128, DecodeType.Code39FullASCII, DecodeType.Planet, DecodeType.QR, DecodeType.MicroQR, DecodeType.DataMatrix))
            {
                read.QualitySettings.BarcodeQuality = BarcodeQualityMode.High;
                read.QualitySettings.Deconvolution = DeconvolutionMode.Fast;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with BarcodeQualityMode Normal, DeconvolutionMode Normal
            Console.WriteLine("BarcodeQualityMode: Normal, DeconvolutionMode: Normal");
            using (BarCodeReader read = new BarCodeReader($"{path}manybarcodes_quality_deconvolution.png", DecodeType.Code128, DecodeType.Code39FullASCII, DecodeType.Planet, DecodeType.QR, DecodeType.MicroQR, DecodeType.DataMatrix))
            {
                read.QualitySettings.BarcodeQuality = BarcodeQualityMode.Normal;
                read.QualitySettings.Deconvolution = DeconvolutionMode.Normal;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with BarcodeQualityMode Low, DeconvolutionMode Normal
            Console.WriteLine("BarcodeQualityMode: Low, DeconvolutionMode: Normal");
            using (BarCodeReader read = new BarCodeReader($"{path}manybarcodes_quality_deconvolution.png", DecodeType.Code128, DecodeType.Code39FullASCII, DecodeType.Planet, DecodeType.QR, DecodeType.MicroQR, DecodeType.DataMatrix))
            {
                read.QualitySettings.BarcodeQuality = BarcodeQualityMode.Low;
                read.QualitySettings.Deconvolution = DeconvolutionMode.Normal;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with BarcodeQualityMode Normal, DeconvolutionMode Slow
            Console.WriteLine("BarcodeQualityMode: Normal, DeconvolutionMode: Slow");
            using (BarCodeReader read = new BarCodeReader($"{path}manybarcodes_quality_deconvolution.png", DecodeType.Code128, DecodeType.Code39FullASCII, DecodeType.Planet, DecodeType.QR, DecodeType.MicroQR, DecodeType.DataMatrix))
            {
                read.QualitySettings.BarcodeQuality = BarcodeQualityMode.Normal;
                read.QualitySettings.Deconvolution = DeconvolutionMode.Slow;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }

            //recognize image with BarcodeQualityMode Low, DeconvolutionMode Slow
            Console.WriteLine("BarcodeQualityMode: Low, DeconvolutionMode: Slow");
            using (BarCodeReader read = new BarCodeReader($"{path}manybarcodes_quality_deconvolution.png", DecodeType.Code128, DecodeType.Code39FullASCII, DecodeType.Planet, DecodeType.QR, DecodeType.MicroQR, DecodeType.DataMatrix))
            {
                read.QualitySettings.BarcodeQuality = BarcodeQualityMode.Low;
                read.QualitySettings.Deconvolution = DeconvolutionMode.Slow;
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}