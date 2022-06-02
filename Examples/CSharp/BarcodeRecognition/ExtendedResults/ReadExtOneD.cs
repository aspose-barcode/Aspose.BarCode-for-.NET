//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtOneD : ReadExtendedBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();

            //generate EAN13 with metadata
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.EAN13, "1234567890128"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Save($"{path}EAN13.png", BarCodeImageFormat.Png);
            }

            //try to recognize EAN13 with value and cheksum
            Console.WriteLine("ReadExtOneD:");
            using (BarCodeReader read = new BarCodeReader($"{path}EAN13.png", DecodeType.EAN13))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"Value:{result.Extended.OneD.Value}");
                    Console.WriteLine($"CheckSum:{result.Extended.OneD.CheckSum}");
                }
            }
        }
	}
}