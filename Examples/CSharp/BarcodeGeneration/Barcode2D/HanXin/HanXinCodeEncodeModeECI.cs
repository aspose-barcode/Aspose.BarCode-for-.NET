//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class HanXinCodeEncodeModeECI : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("HanXinCodeEncodeModeECI:");
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.HanXin, "犬Right狗");
            //EncodeMode ECI
            gen.Parameters.Barcode.HanXin.EncodeMode = HanXinEncodeMode.ECI;
            gen.Parameters.Barcode.HanXin.ECIEncoding = ECIEncodings.UTF16BE;
            gen.Save($"{path}HanXinCodeEncodeModeECI.png", BarCodeImageFormat.Png);

            using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.HanXin))
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    System.Console.WriteLine($"CodeText:{result.CodeText}");
        }
    }
}