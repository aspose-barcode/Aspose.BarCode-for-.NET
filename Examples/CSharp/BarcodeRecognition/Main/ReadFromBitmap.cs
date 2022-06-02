//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using System.Drawing;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadFromBitmap : ReadMainBase
    {
		public static void Run()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string path = GetReadFolder();
            using (Bitmap bmp = new Bitmap($"{path}multiple_codes.png"))
            using (BarCodeReader reader = new BarCodeReader(bmp, DecodeType.Pdf417, DecodeType.DataMatrix, DecodeType.QR,
                DecodeType.Code39Extended, DecodeType.Code128, DecodeType.RM4SCC))
            {
                Console.WriteLine("ReadFromBitmap:");
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}