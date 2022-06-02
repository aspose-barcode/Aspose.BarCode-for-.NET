//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadAustraliaPostNTable : ReadDecodingBase
    {
		public static void Run()
        {
            string path = GetFolder();
            
            //create barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.AustraliaPost, "620123456701234"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Parameters.Barcode.BarHeight.Pixels = 50;
                gen.Parameters.Barcode.AustralianPost.AustralianPostEncodingTable = CustomerInformationInterpretingType.NTable;
                gen.Save($"{path}AustraliaPostNTable.png", BarCodeImageFormat.Png);
            }
            
            //recognize image
            Console.WriteLine("ReadAustraliaPostNTable:");
            using (BarCodeReader read = new BarCodeReader($"{path}AustraliaPostNTable.png", DecodeType.AustraliaPost))
            {
                read.BarcodeSettings.AustraliaPost.CustomerInformationInterpretingType = CustomerInformationInterpretingType.NTable;
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
            }
        }
	}
}