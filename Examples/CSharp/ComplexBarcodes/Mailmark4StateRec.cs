//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class Mailmark4StateRec : ComplexBarcodesReadBase
    {
		public static void Run()
        {
            string path = GetMailmarkFolder();
            System.Console.WriteLine("Mailmark4StateRec:");

            Console.OutputEncoding = Encoding.Unicode;
            //recognize Mailmark 4-State Code
            BarCodeReader reader = new BarCodeReader($"{path}Mailmark4State.png", DecodeType.Mailmark);
            foreach (BarCodeResult result in reader.ReadBarCodes())
            {
                MailmarkCodetext mailmarkResult = ComplexCodetextReader.TryDecodeMailmark(result.CodeText);
                if (null == mailmarkResult) continue;
                Console.WriteLine($"Format:{mailmarkResult.Format}");
                Console.WriteLine($"VersionID:{mailmarkResult.VersionID}");
                Console.WriteLine($"Class:{mailmarkResult.Class}");
                Console.WriteLine($"SupplychainID:{mailmarkResult.SupplychainID}");
                Console.WriteLine($"ItemID:{mailmarkResult.ItemID}");
                Console.WriteLine($"DestinationPostCodePlusDPS:{mailmarkResult.DestinationPostCodePlusDPS}");
            }
        }
	}
}