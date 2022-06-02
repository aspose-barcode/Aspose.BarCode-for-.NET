//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadChecksumCode11 : ReadDecodingBase
    {
		public static void Run()
        {
            string path = GetFolder();
            //create barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code11, "123456"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Save($"{path}Code11.png", BarCodeImageFormat.Png);
            }

            //recognize image with ChecksumValidation.Default
            Console.WriteLine("ReadChecksumCode11:");
            Console.WriteLine("ChecksumValidation: Default");
            using (BarCodeReader read = new BarCodeReader($"{path}Code11.png", DecodeType.Code11))
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

            //recognize image with ChecksumValidation.Off
            Console.WriteLine("ChecksumValidation: Off");
            using (BarCodeReader read = new BarCodeReader($"{path}Code11.png", DecodeType.Code11))
            {
                read.BarcodeSettings.ChecksumValidation = ChecksumValidation.Off;
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