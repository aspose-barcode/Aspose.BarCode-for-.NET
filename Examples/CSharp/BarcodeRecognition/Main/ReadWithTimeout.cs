//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadWithTimeout : ReadMainBase
    {
		public static void Run()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string path = GetReadFolder();
            using (BarCodeReader reader = new BarCodeReader($"{path}multiple_codes.png", DecodeType.Pdf417, DecodeType.DataMatrix, DecodeType.QR,
                DecodeType.Code39Extended, DecodeType.Code128, DecodeType.RM4SCC))
            {
                Console.WriteLine("ReadWithTimeout:");
                reader.Timeout = 50;
                try
                {
                    reader.ReadBarCodes();
                }
                catch(RecognitionAbortedException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
	}
}