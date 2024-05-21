//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecEncodeModeBinary : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecEncodeModeBinart:");

            byte[] encodedArr = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 };
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                //set encode mode Binary
                gen.SetCodeText(encodedArr);
                gen.Parameters.Barcode.Aztec.AztecEncodeMode = AztecEncodeMode.Binary;
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Binary mode";
                gen.Save($"{path}AztecEncodeModeBinary.png", BarCodeImageFormat.Png);

                //try to recognize
                using (BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.Aztec))
                {
                    foreach (BarCodeResult result in read.ReadBarCodes())
                        Console.WriteLine("AztecEncodeModeBinary:" + BitConverter.ToString(result.CodeBytes));
                }
            }
        }
	}
}