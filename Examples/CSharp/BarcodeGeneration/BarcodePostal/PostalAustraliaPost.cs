//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class PostalAustraliaPost : PostalBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("PostalAustraliaPost:");

            BarcodeGenerator gen = null;
            //create AustraliaPost FCC 11
            gen = new BarcodeGenerator(EncodeTypes.AustraliaPost, "1101234567");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Save($"{path}PostalAustraliaPostFCC11.png", BarCodeImageFormat.Png);
            //create AustraliaPost FCC 59 NTable
            gen = new BarcodeGenerator(EncodeTypes.AustraliaPost, "590123456701234");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Parameters.Barcode.AustralianPost.AustralianPostEncodingTable = CustomerInformationInterpretingType.NTable;
            gen.Save($"{path}PostalAustraliaPostFCC59NTable.png", BarCodeImageFormat.Png);
            //create AustraliaPost FCC 62 NTable
            gen = new BarcodeGenerator(EncodeTypes.AustraliaPost, "620123456701234");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Parameters.Barcode.AustralianPost.AustralianPostEncodingTable = CustomerInformationInterpretingType.NTable;
            gen.Save($"{path}PostalAustraliaPostFCC62NTable.png", BarCodeImageFormat.Png);
            //create AustraliaPost FCC 62 CTable
            gen = new BarcodeGenerator(EncodeTypes.AustraliaPost, "6201234567ASPOSE");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Parameters.Barcode.AustralianPost.AustralianPostEncodingTable = CustomerInformationInterpretingType.CTable;
            gen.Save($"{path}PostalAustraliaPostFCC62CTable.png", BarCodeImageFormat.Png);
            //create AustraliaPost FCC 62
            gen = new BarcodeGenerator(EncodeTypes.AustraliaPost, "6201234567321032103210");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Parameters.Barcode.AustralianPost.AustralianPostEncodingTable = CustomerInformationInterpretingType.Other;
            gen.Save($"{path}PostalAustraliaPostFCC62OtherTable.png", BarCodeImageFormat.Png);
        }
    }
}