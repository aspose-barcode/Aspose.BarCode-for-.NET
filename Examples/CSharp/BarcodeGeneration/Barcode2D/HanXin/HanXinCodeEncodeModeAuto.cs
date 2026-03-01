//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class HanXinCodeEncodeModeAuto : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("HanXinCodeEncodeModeAuto:");
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.HanXin, "犬Right狗");
            //EncodeMode Auto
            gen.Parameters.Barcode.HanXin.EncodeMode = HanXinEncodeMode.Auto;
            gen.Save($"{path}HanXinCodeEncodeModeAuto.png", BarCodeImageFormat.Png);

            using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.HanXin))
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    System.Console.WriteLine($"CodeText:{result.CodeText}");
        }
    }
}