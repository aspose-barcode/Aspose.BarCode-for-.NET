//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class SwissQRCodeGenRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("SwissQRCodeGenRec:");

            Console.OutputEncoding = Encoding.Unicode;
            //create Swiss QR Bill
            SwissQRCodetext swissQRCode = new SwissQRCodetext();
            swissQRCode.Bill.Version = SwissQRBill.QrBillStandardVersion.V2_0;
            swissQRCode.Bill.Account = "CH4431999123000889012";
            swissQRCode.Bill.Amount = 1000.25m;
            swissQRCode.Bill.Currency = "CHF";
            swissQRCode.Bill.Reference = "210000000003139471430009017";
            swissQRCode.Bill.Creditor = new Address
            {
                Name = "Muster & Söhne",
                Street = "Musterstrasse",
                HouseNo = "12b",
                PostalCode = "8200",
                Town = "Zürich",
                CountryCode = "CH"
            };

            swissQRCode.Bill.Debtor = new Address
            {
                Name = "Muster AG",
                Street = "Musterstrasse",
                HouseNo = "1",
                PostalCode = "3030",
                Town = "Bern",
                CountryCode = "CH"
            };

            //encode it
            ComplexBarcodeGenerator generator = new ComplexBarcodeGenerator(swissQRCode);
            generator.Parameters.Barcode.XDimension.Pixels = 4;
            generator.Parameters.Barcode.QR.QrEncodeMode = QREncodeMode.ECIEncoding;
            generator.Parameters.Barcode.QR.QrECIEncoding = ECIEncodings.UTF8;
            generator.Save($"{path}SwissQRBill.png");

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