//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class HIBCLICSecondaryGenRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("HIBCLICSecondaryGenRec:");

            //create HIBC LIC Code
            HIBCLICSecondaryAndAdditionalDataCodetext complexCodetext = new HIBCLICSecondaryAndAdditionalDataCodetext();
            complexCodetext.BarcodeType = EncodeTypes.HIBCQRLIC;
            //create secondary data
            complexCodetext.Data = new SecondaryAndAdditionalData();
            complexCodetext.Data.ExpiryDate = DateTime.Now;
            complexCodetext.Data.ExpiryDateFormat = HIBCLICDateFormat.MMDDYY;
            complexCodetext.Data.Quantity = 30;
            complexCodetext.Data.LotNumber = "LOT123";
            complexCodetext.Data.SerialNumber = "SERIAL123";
            complexCodetext.Data.DateOfManufacture = DateTime.Now;
            complexCodetext.LinkCharacter = 'S';

            //encode HIBC LIC Code
            using (ComplexBarcodeGenerator gen = new ComplexBarcodeGenerator(complexCodetext))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 10;
                gen.Save($"{path}HIBCLICSecondary.png");
            }

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