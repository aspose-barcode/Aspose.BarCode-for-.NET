//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class Mailmark2DRec : ComplexBarcodesReadBase
    {
		public static void Run()
        {
            string path = GetMailmarkFolder();
            System.Console.WriteLine("Mailmark2DRec:");

            Console.OutputEncoding = Encoding.Unicode;
            //recognize Mailmark 2D Code
            BarCodeReader reader = new BarCodeReader($"{path}Mailmark2DType9.png", DecodeType.DataMatrix);
            foreach (BarCodeResult result in reader.ReadBarCodes())
            {
                Mailmark2DCodetext mailmarkResult = ComplexCodetextReader.TryDecodeMailmark2D(result.CodeText);
                if (null == mailmarkResult) continue;
                Console.WriteLine($"UPUCountryID:{mailmarkResult.UPUCountryID}");
                Console.WriteLine($"InformationTypeID:{mailmarkResult.InformationTypeID}");
                Console.WriteLine($"VersionID:{mailmarkResult.VersionID}");
                Console.WriteLine($"Class:{mailmarkResult.Class}");
                Console.WriteLine($"SupplyChainID:{mailmarkResult.SupplyChainID}");
                Console.WriteLine($"ItemID:{mailmarkResult.ItemID}");
                Console.WriteLine($"DestinationPostCodeAndDPS:{mailmarkResult.DestinationPostCodeAndDPS}");
                Console.WriteLine($"RTSFlag:{mailmarkResult.RTSFlag}");
                Console.WriteLine($"ReturnToSenderPostCode:{mailmarkResult.ReturnToSenderPostCode}");
                Console.WriteLine($"CustomerContent:{mailmarkResult.CustomerContent}");
            }
        }
    }
}