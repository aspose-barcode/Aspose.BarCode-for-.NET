//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;
#if NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_1_OR_GREATER
using Aspose.Drawing;
#else
using System.Drawing;
#endif

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtRegion : ReadExtendedBase
    {
		public static void Run()
        {
            string path = GetReadFolder();
            //recognize image
            Console.WriteLine("ReadExtRegion:");
            using (BarCodeReader read = new BarCodeReader($"{path}qr_code128.png", DecodeType.QR, DecodeType.Code128))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"Quadrangle:{result.Region.Quadrangle.ToString()}");
                    Console.WriteLine($"Angle:{result.Region.Angle.ToString()}");
                    Console.WriteLine($"Rectangle:{result.Region.Rectangle.ToString()}");
                    string ptStr = "";
                    foreach (Point pt in result.Region.Points)
                        ptStr += pt.ToString() + "";
                    Console.WriteLine($"Points:{ptStr}");
                }
            }
        }
	}
}