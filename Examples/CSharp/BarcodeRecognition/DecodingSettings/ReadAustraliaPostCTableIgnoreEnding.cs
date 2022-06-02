//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadAustraliaPostCTableIgnoreEnding : ReadDecodingBase
    {
		public static void Run()
        {
            string path = GetFolder();
            
            //create barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.AustraliaPost, "6201234567END"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Parameters.Barcode.BarHeight.Pixels = 50;
                gen.Parameters.Barcode.AustralianPost.AustralianPostEncodingTable = CustomerInformationInterpretingType.CTable;
                gen.Save($"{path}AustraliaPostCTableIgnoreEnding.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("ReadAustraliaPostCTableIgnoreEnding:");
            //recognize image with IgnoreEndingFillingPatternsForCTable true
            Console.WriteLine("IgnoreEndingFillingPatternsForCTable: true");
            using (BarCodeReader read = new BarCodeReader($"{path}AustraliaPostCTableIgnoreEnding.png", DecodeType.AustraliaPost))
            {
                read.BarcodeSettings.AustraliaPost.CustomerInformationInterpretingType = CustomerInformationInterpretingType.CTable;
                read.BarcodeSettings.AustraliaPost.IgnoreEndingFillingPatternsForCTable = true;
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
            }

            //recognize image with IgnoreEndingFillingPatternsForCTable false
            Console.WriteLine("IgnoreEndingFillingPatternsForCTable: false");
            using (BarCodeReader read = new BarCodeReader($"{path}AustraliaPostCTableIgnoreEnding.png", DecodeType.AustraliaPost))
            {
                read.BarcodeSettings.AustraliaPost.CustomerInformationInterpretingType = CustomerInformationInterpretingType.CTable;
                read.BarcodeSettings.AustraliaPost.IgnoreEndingFillingPatternsForCTable = false;
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
            }
        }
    }
}