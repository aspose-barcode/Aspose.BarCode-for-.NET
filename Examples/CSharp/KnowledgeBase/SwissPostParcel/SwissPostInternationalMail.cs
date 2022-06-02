//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.KnowledgeBase
{
    internal class SwissPostInternationalMail : SwissPostParcelBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.WriteLine("SwissPostInternationalMail:");
            BarcodeGenerator gen;

            //generate Swiss Post International Mail barcode
            gen = new BarcodeGenerator(EncodeTypes.SwissPostParcel, "RM999605013CH");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.BarHeight.Pixels = 40;
            gen.Save($"{path}SwissPostInternationalMailAsIs.png", BarCodeImageFormat.Png);
            //read the current barcode value
            foreach (BarCodeResult result in new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.SwissPostParcel).ReadBarCodes())
                Console.WriteLine($"Barcode type:{result.CodeTypeName}, Barcode Data:{result.CodeText}");

            //generate Swiss Post International Mail barcode with wrong checksum
            gen = new BarcodeGenerator(EncodeTypes.SwissPostParcel, "RM999605017CH");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.BarHeight.Pixels = 40;
            gen.Save($"{path}SwissPostInternationalMailWithWrongChecksum.png", BarCodeImageFormat.Png);
            //read the current barcode value
            foreach (BarCodeResult result in new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.SwissPostParcel).ReadBarCodes())
                Console.WriteLine($"Barcode type:{result.CodeTypeName}, Barcode Data:{result.CodeText}");

            //generate Swiss Post International Mail barcode without checksum
            gen = new BarcodeGenerator(EncodeTypes.SwissPostParcel, "RM99960501CH");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.BarHeight.Pixels = 40;
            gen.Save($"{path}SwissPostInternationalMailWithoutChecksum.png", BarCodeImageFormat.Png);
            //read the current barcode value
            foreach (BarCodeResult result in new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.SwissPostParcel).ReadBarCodes())
                Console.WriteLine($"Barcode type:{result.CodeTypeName}, Barcode Data:{result.CodeText}");
        }
	}
}