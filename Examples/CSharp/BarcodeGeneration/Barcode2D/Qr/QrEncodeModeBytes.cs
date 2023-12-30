//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class QrEncodeModeBytes : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("QrEncodeModeBytes:");

            byte[] encodedArr = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9};

            //encode array to string
            StringBuilder strBld = new StringBuilder(); ;
            foreach(byte bval in encodedArr)
                strBld.Append((char)bval);
            
            //encode in QR code
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, strBld.ToString());
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            //set encode mode to Bytes
            gen.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.Bytes;
            gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Bytes mode";
            gen.Save($"{path}QrEncodeModeBytes.png", BarCodeImageFormat.Png);

            //try to recognize
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.QR);
            foreach (BarCodeResult result in read.ReadBarCodes())
                Console.WriteLine("QrEncodeModeBytes:" + BitConverter.ToString(result.CodeBytes));
        }
	}
}