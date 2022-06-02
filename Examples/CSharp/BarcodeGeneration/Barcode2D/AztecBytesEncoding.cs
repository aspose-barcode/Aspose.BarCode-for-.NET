//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecBytesEncoding : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecBytesEncoding:");

            byte[] encodedArr = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 };

            //encode array to string
            StringBuilder strBld = new StringBuilder();
            foreach (byte bval in encodedArr)
                strBld.Append((char)bval);

            //encode in Aztec code
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, strBld.ToString());
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            //set symbol mode Auto
            gen.Parameters.Barcode.Aztec.AztecSymbolMode = AztecSymbolMode.Auto;
            gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Bytes mode";
            gen.Save($"{path}AztecBytesEncoding.png", BarCodeImageFormat.Png);

            //try to recognize
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.Aztec);
            foreach (BarCodeResult result in read.ReadBarCodes())
                Console.WriteLine("AztecBytesEncoding:" + BitConverter.ToString(result.CodeBytes));
        }
	}
}