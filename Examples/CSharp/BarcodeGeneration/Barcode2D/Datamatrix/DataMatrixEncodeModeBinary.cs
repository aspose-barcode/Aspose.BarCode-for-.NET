//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DataMatrixEncodeModeBinary : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DataMatrixEncodeModeBinary:");

            byte[] encodedArr = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 };

            //encode in DataMatrix code
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                //set encode mode to binary
                gen.SetCodeText(encodedArr);
                gen.Parameters.Barcode.DataMatrix.DataMatrixEncodeMode = DataMatrixEncodeMode.Binary;
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Binary mode";
                gen.Save($"{path}DataMatrixEncodeModeBinary.png", BarCodeImageFormat.Png);

                //try to recognize
                using (BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.DataMatrix))
                {
                    foreach (BarCodeResult result in read.ReadBarCodes())
                        Console.WriteLine("DataMatrixEncodeModeBinary:" + BitConverter.ToString(result.CodeBytes));
                }
            }
        }
	}
}