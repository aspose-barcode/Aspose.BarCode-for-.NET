//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class HanXinCodeEncodeModeBinary : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("HanXinCodeEncodeModeBinary:");
            
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.HanXin);
            //EncodeMode Binary
            gen.SetCodeText(new byte[] { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 });
            gen.Parameters.Barcode.HanXin.EncodeMode = HanXinEncodeMode.Binary;
            gen.Save($"{path}HanXinCodeEncodeModeBinary.png", BarCodeImageFormat.Png);

            using (BarCodeReader reader = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.HanXin))
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    System.Console.WriteLine("HanXinCodeEncodeModeBinary:" + BitConverter.ToString(result.CodeBytes));
        }
    }
}