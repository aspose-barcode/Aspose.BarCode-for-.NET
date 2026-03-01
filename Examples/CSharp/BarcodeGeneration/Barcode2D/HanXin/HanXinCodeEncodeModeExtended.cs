//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class HanXinCodeEncodeModeExtended : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("HanXinCodeEncodeModeExtended:");
            string str = @"\auto:abc\000009:ΑΒΓΔΕ\auto:abc";
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.HanXin, str);
            //EncodeMode Extended
            gen.Parameters.Barcode.HanXin.EncodeMode = HanXinEncodeMode.Extended;
            gen.Save($"{path}HanXinCodeEncodeModeExtended.png", BarCodeImageFormat.Png);

            using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.HanXin))
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    System.Console.WriteLine($"CodeText:{result.CodeText}");
        }
    }
}