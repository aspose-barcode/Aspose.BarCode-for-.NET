//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadChecksumCode39 : ReadDecodingBase
    {
		public static void Run()
        {
            string path = GetFolder();

            //create barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code39FullASCII, "123456"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.IsChecksumEnabled = EnableChecksum.Yes;
                gen.Save($"{path}Code39.png", BarCodeImageFormat.Png);
            }

            //recognize image with ChecksumValidation.Default
            Console.WriteLine("ReadChecksumCode39:");
            Console.WriteLine("ChecksumValidation: Default");
            using (BarCodeReader read = new BarCodeReader($"{path}Code39.png", DecodeType.Code39FullASCII))
            {
                read.BarcodeSettings.ChecksumValidation = ChecksumValidation.Default;
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"1D Value:{result.Extended.OneD.Value}");
                    Console.WriteLine($"1D CheckSum:{result.Extended.OneD.CheckSum}");
                }
            }

            //recognize image with ChecksumValidation.On
            Console.WriteLine("ChecksumValidation: On");
            using (BarCodeReader read = new BarCodeReader($"{path}Code39.png", DecodeType.Code39FullASCII))
            {
                read.BarcodeSettings.ChecksumValidation = ChecksumValidation.On;
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"1D Value:{result.Extended.OneD.Value}");
                    Console.WriteLine($"1D CheckSum:{result.Extended.OneD.CheckSum}");
                }
            }
        }
	}
}