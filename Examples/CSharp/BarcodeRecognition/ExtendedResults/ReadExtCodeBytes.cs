//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtCodeBytes : ReadExtendedBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            
            byte[] encodedArr = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 };

            //encode array to string
            StringBuilder strBld = new StringBuilder(encodedArr.Length);
            foreach (byte bval in encodedArr)
                strBld.Append((char)bval);

            //encode bytes array
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, strBld.ToString()))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.Pdf417.Pdf417CompactionMode = Pdf417CompactionMode.Binary;
                gen.Parameters.Barcode.Pdf417.Columns = 2;
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Bytes mode";
                gen.Save($"{path}ExtCodeBytes.png", BarCodeImageFormat.Png);
            }

            //try to recognize bytes array
            Console.WriteLine("ReadExtCodeBytes:");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtCodeBytes.png", DecodeType.Pdf417))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeTypeName:{result.CodeTypeName}");
                    Console.WriteLine($"CodeBytes:{BitConverter.ToString(result.CodeBytes)}");
                }
        }
	}
}