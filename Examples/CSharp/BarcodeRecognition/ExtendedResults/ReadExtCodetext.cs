//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtCodetext : ReadExtendedBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.OutputEncoding = Encoding.Unicode;

            //create barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Save($"{path}QRCodetext.png", BarCodeImageFormat.Png);
            }

            //recognize image
            Console.WriteLine("ReadExtCodetext:");
            using (BarCodeReader read = new BarCodeReader($"{path}QRCodetext.png", DecodeType.QR))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"CodeType:{result.CodeType.ToString()}");
                    Console.WriteLine($"CodeTypeName:{result.CodeTypeName}");
                }
            }
        }
	}
}