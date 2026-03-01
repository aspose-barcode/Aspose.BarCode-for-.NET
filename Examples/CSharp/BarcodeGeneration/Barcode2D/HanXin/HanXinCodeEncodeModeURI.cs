//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class HanXinCodeEncodeModeURI : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("HanXinCodeEncodeModeURI:");
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.HanXin, "https://www.test.com/%BC%DE%%%ab/search=test");
            //EncodeMode URI
            gen.Parameters.Barcode.HanXin.EncodeMode = HanXinEncodeMode.URI;
            gen.Save($"{path}HanXinCodeEncodeModeURI.png", BarCodeImageFormat.Png);

            using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.HanXin))
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    System.Console.WriteLine($"CodeText:{result.CodeText}");
        }
    }
}