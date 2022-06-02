//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadWithStripFNC : ReadDecodingBase
    {
        public static void Run()
        {
            string path = GetFolder();
            char FNC1 = (char)207;
            char FNC2 = (char)202;
            char FNC3 = (char)201;

            //create barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "Aspose" + FNC1 + FNC2 + FNC3))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Save($"{path}Code128FNC.png", BarCodeImageFormat.Png);
            }

            //recognize image with StripFNC false
            Console.WriteLine("ReadWithStripFNC:");
            Console.WriteLine("StripFNC: false");
            using (BarCodeReader read = new BarCodeReader($"{path}Code128FNC.png", DecodeType.Code128))
            {
                read.BarcodeSettings.StripFNC = false;
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
            }

            //recognize image with StripFNC true
            Console.WriteLine("StripFNC: true");
            using (BarCodeReader read = new BarCodeReader($"{path}Code128FNC.png", DecodeType.Code128))
            {
                read.BarcodeSettings.StripFNC = true;
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
            }
        }
    }
}