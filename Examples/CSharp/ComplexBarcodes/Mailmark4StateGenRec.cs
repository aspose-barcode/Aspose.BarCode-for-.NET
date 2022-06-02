//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class Mailmark4StateGenRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Mailmark4StateGenRec:");

            Console.OutputEncoding = Encoding.Unicode;
            //create Mailmark 4-State Code
            MailmarkCodetext mailmarkCode = new MailmarkCodetext();
            mailmarkCode.Format = 4;
            mailmarkCode.VersionID = 1;
            mailmarkCode.Class = "0";
            mailmarkCode.SupplychainID = 384224;
            mailmarkCode.ItemID = 16563762;
            mailmarkCode.DestinationPostCodePlusDPS = "EF61AH8T ";

            //encode it
            ComplexBarcodeGenerator generator = new ComplexBarcodeGenerator(mailmarkCode);
            generator.Parameters.Barcode.XDimension.Pixels = 4;
            generator.Save($"{path}Mailmark4State.png");

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