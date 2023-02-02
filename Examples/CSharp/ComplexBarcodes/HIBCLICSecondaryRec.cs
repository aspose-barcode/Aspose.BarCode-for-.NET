//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class HIBCLICSecondaryRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("HIBCLICSecondaryRec:");

            //recognize HIBC LIC Code
            using (BarCodeReader reader = new BarCodeReader($"{path}HIBCLICSecondary.png", DecodeType.HIBCQRLIC))
            {
                foreach (BarCodeResult result in reader.ReadBarCodes())
                {
                    HIBCLICComplexCodetext codetext = ComplexCodetextReader.TryDecodeHIBCLIC(result.CodeText);
                    HIBCLICSecondaryAndAdditionalDataCodetext secondaryDataCodetext = codetext as HIBCLICSecondaryAndAdditionalDataCodetext;
                    if (secondaryDataCodetext == null)
                        continue;

                    Console.WriteLine("Expiry date: " + secondaryDataCodetext.Data.ExpiryDate);
                    Console.WriteLine("Quantity: " + secondaryDataCodetext.Data.Quantity);
                    Console.WriteLine("Lot number: " + secondaryDataCodetext.Data.LotNumber);
                    Console.WriteLine("Serial number: " + secondaryDataCodetext.Data.SerialNumber);
                    Console.WriteLine("Date of manufacture: " + secondaryDataCodetext.Data.DateOfManufacture);
                }
            }
        }
    }
}