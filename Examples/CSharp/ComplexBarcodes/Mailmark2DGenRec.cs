//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class Mailmark2DGenRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Mailmark2DGenRec:");

            Console.OutputEncoding = Encoding.Unicode;
            ComplexBarcodeGenerator generator = null;

            //create Mailmark 2D Code
            Mailmark2DCodetext mailmark2D = new Mailmark2DCodetext();
            mailmark2D.UPUCountryID = "JGB ";
            mailmark2D.InformationTypeID = "0";
            mailmark2D.VersionID = "1";
            mailmark2D.Class = "1";
            mailmark2D.SupplyChainID = 123;
            mailmark2D.ItemID = 1234;
            mailmark2D.DestinationPostCodeAndDPS = "QWE1";
            mailmark2D.RTSFlag = "0";
            mailmark2D.ReturnToSenderPostCode = "QWE2";

            //encode Mailmark 2D Type 7 Code
            mailmark2D.DataMatrixType = Mailmark2DType.Type_7;
            mailmark2D.CustomerContent = "CUSTOM";
            generator = new ComplexBarcodeGenerator(mailmark2D);
            generator.Parameters.Barcode.XDimension.Pixels = 4;
            generator.Save($"{path}Mailmark2DType7.png");

            //encode Mailmark 2D Type 9 Code
            mailmark2D.DataMatrixType = Mailmark2DType.Type_9;
            mailmark2D.CustomerContent = "CUSTOM DATA";
            generator = new ComplexBarcodeGenerator(mailmark2D);
            generator.Parameters.Barcode.XDimension.Pixels = 4;
            generator.Save($"{path}Mailmark2DType9.png");

            //encode Mailmark 2D Type 29 Code
            mailmark2D.DataMatrixType = Mailmark2DType.Type_29;
            mailmark2D.CustomerContent = "CUSTOM DATA";
            generator = new ComplexBarcodeGenerator(mailmark2D);
            generator.Parameters.Barcode.XDimension.Pixels = 4;
            generator.Save($"{path}Mailmark2DType29.png");

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