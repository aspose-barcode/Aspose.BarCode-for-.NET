//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class SwissQRCodeRec : ComplexBarcodesReadBase
    {
		public static void Run()
        {
            string path = GetSwissQRFolder();
            System.Console.WriteLine("SwissQRCodeRec:");

            Console.OutputEncoding = Encoding.Unicode;
            //recognize Swiss QR Code
            BarCodeReader reader = new BarCodeReader($"{path}SwissQRBill.png", DecodeType.QR);
            foreach (BarCodeResult result in reader.ReadBarCodes())
            {
                SwissQRCodetext swissResult = ComplexCodetextReader.TryDecodeSwissQR(result.CodeText);
                if (null == swissResult) continue;
                Console.WriteLine($"Version:{swissResult.Bill.Version}");
                Console.WriteLine($"Account:{swissResult.Bill.Account}");
                Console.WriteLine($"Amount:{swissResult.Bill.Amount}");
                Console.WriteLine($"Currency:{swissResult.Bill.Currency}");
                Console.WriteLine($"Reference:{swissResult.Bill.Reference}");
                Console.WriteLine($"Creditor:{swissResult.Bill.Creditor.Name}");
                Console.WriteLine($"Debtor:{swissResult.Bill.Debtor.Name}");
            }
        }
	}
}