//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using System.Drawing;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadSetBarCodeRegion : ReadMainBase
    {
		public static void Run()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string path = GetReadFolder();
            //rectangle of 2D barcode on our image
            Rectangle rect2D = new Rectangle(0, 0, 430, 440);
            using (Bitmap bmp = new Bitmap($"{path}multiple_codes.png"))
            using (BarCodeReader reader = new BarCodeReader())
            {
                reader.SetBarCodeImage(bmp, rect2D);
                reader.SetBarCodeReadType(DecodeType.Pdf417, DecodeType.DataMatrix, DecodeType.QR, DecodeType.Code39Extended, DecodeType.Code128, DecodeType.RM4SCC);
                Console.WriteLine("ReadSetBarCodeRegion:");
                foreach (BarCodeResult result in reader.ReadBarCodes())
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
	}
}