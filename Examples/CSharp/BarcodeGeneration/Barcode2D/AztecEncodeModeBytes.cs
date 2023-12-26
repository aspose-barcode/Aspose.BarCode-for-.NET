//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecEncodeModeBytes : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecEncodeModeBytes:");

            byte[] encodedArr = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 };

            //encode array to string
            StringBuilder strBld = new StringBuilder();
            foreach (byte bval in encodedArr)
                strBld.Append((char)bval);

            //encode in Aztec code
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, strBld.ToString()))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                //set encode mode Bytes
                gen.Parameters.Barcode.Aztec.AztecEncodeMode = AztecEncodeMode.Bytes;
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Bytes mode";
                gen.Save($"{path}AztecEncodeModeBytes.png", BarCodeImageFormat.Png);

                //try to recognize
                using (BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.Aztec))
                {
                    foreach (BarCodeResult result in read.ReadBarCodes())
                        Console.WriteLine("AztecEncodeModeBytes:" + BitConverter.ToString(result.CodeBytes));
                }
            }
        }
	}
}