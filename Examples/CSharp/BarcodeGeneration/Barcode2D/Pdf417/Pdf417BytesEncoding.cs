//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Pdf417BytesEncoding : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Pdf417BytesEncoding:");

            byte[] encodedArr = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 };

            //encode array to string
            StringBuilder strBld = new StringBuilder();
            foreach (byte bval in encodedArr)
                strBld.Append((char)bval);

            //encode in Pdf417 code
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, strBld.ToString());
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.Below;
            gen.Parameters.Barcode.Pdf417.Columns = 3;
            //set encode mode to Binary
            gen.Parameters.Barcode.Pdf417.Pdf417CompactionMode = Pdf417CompactionMode.Binary;
            gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Bytes mode";
            gen.Save($"{path}Pdf417BytesEncoding.png", BarCodeImageFormat.Png);

            //try to recognize
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.Pdf417);
            foreach (BarCodeResult result in read.ReadBarCodes())
                Console.WriteLine("Pdf417BytesEncoding:" + BitConverter.ToString(result.CodeBytes));
        }
	}
}