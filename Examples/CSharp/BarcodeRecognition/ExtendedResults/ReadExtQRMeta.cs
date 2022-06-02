//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtQRMeta : ReadExtendedBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.OutputEncoding = Encoding.Unicode;

            //generate QR with metadata
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Parameters.Barcode.QR.StructuredAppend.TotalCount = 3;
                gen.Parameters.Barcode.QR.StructuredAppend.SequenceIndicator = 1;
                gen.Parameters.Barcode.QR.StructuredAppend.ParityByte = 123;
                gen.Save($"{path}ExtQRMeta.png", BarCodeImageFormat.Png);
            }

            //try to recognize QR metadata
            Console.WriteLine("ReadExtQRMeta:");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtQRMeta.png", DecodeType.QR))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"BarCodesQuantity:{result.Extended.QR.QRStructuredAppendModeBarCodesQuantity}");
                    Console.WriteLine($"BarCodeIndex:{result.Extended.QR.QRStructuredAppendModeBarCodeIndex}");
                    Console.WriteLine($"ParityData:{result.Extended.QR.QRStructuredAppendModeParityData}");
                }
            }
        }
	}
}