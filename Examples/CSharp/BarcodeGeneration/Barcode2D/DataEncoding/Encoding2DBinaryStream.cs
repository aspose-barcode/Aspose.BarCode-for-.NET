//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Encoding2DBinaryStream: TwoDEncodingBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Encoding2DBinaryStream:");

            Stream encodedStream = CreateStream();
            encodedStream.Position = 0;
            byte[] encodedArr = new byte[encodedStream.Length];
            encodedStream.Read(encodedArr, 0, encodedArr.Length);

            //encode in DataMatrix code
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 8;
                //set encode mode to binary
                gen.SetCodeText(encodedArr);
                gen.Parameters.Barcode.DataMatrix.DataMatrixEncodeMode = DataMatrixEncodeMode.Binary;
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Binary mode";
                gen.Save($"{path}Encoding2DBinaryStream.png", BarCodeImageFormat.Png);

                //try to recognize
                using (BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.DataMatrix))
                    foreach (BarCodeResult result in read.ReadBarCodes())
                        Console.WriteLine("Encoding2DBinaryStream:" + BitConverter.ToString(result.CodeBytes));
            }
        }

        protected static Stream CreateStream()
        {
            byte[] arr = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 };
            MemoryStream stream = new MemoryStream(arr);
            return stream;
        }
    }
}