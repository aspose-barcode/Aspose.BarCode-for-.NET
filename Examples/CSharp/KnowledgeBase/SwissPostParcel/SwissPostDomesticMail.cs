//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.KnowledgeBase
{
    internal class SwissPostDomesticMail : SwissPostParcelBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.WriteLine("SwissPostDomesticMail:");
            BarcodeGenerator gen;

            //generate Swiss Post Domestic Mail barcode as it looks
            gen = new BarcodeGenerator(EncodeTypes.SwissPostParcel, "98.34.123456.12345678");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.BarHeight.Pixels = 40;
            gen.Save($"{path}SwissPostDomesticMailAsIs.png", BarCodeImageFormat.Png);
            //read the current barcode value
            foreach(BarCodeResult result in new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.SwissPostParcel).ReadBarCodes())
                Console.WriteLine($"Barcode type:{result.CodeTypeName}, Barcode Data:{result.CodeText}");

            //generate Swiss Post Domestic Mail barcode as raw digits
            gen = new BarcodeGenerator(EncodeTypes.SwissPostParcel, "983412345612345678");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.BarHeight.Pixels = 40;
            gen.Save($"{path}SwissPostDomesticMailAsDigits.png", BarCodeImageFormat.Png);
            //read the current barcode value
            foreach (BarCodeResult result in new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.SwissPostParcel).ReadBarCodes())
                Console.WriteLine($"Barcode type:{result.CodeTypeName}, Barcode Data:{result.CodeText}");
        }
	}
}