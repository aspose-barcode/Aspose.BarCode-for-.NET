//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class HIBCLICCombinedGenRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("HIBCLICPrimaryGenRec:");

            //create HIBC LIC Combined Code
            HIBCLICCombinedCodetext complexCodetext = new HIBCLICCombinedCodetext();
            complexCodetext.BarcodeType = EncodeTypes.HIBCQRLIC;
            //create primary data
            complexCodetext.PrimaryData = new PrimaryData();
            complexCodetext.PrimaryData.ProductOrCatalogNumber = "12345";
            complexCodetext.PrimaryData.LabelerIdentificationCode = "A999";
            complexCodetext.PrimaryData.UnitOfMeasureID = 1;
            //create secondary data
            complexCodetext.SecondaryAndAdditionalData = new SecondaryAndAdditionalData();
            complexCodetext.SecondaryAndAdditionalData.ExpiryDate = DateTime.Now;
            complexCodetext.SecondaryAndAdditionalData.ExpiryDateFormat = HIBCLICDateFormat.MMDDYY;
            complexCodetext.SecondaryAndAdditionalData.Quantity = 30;
            complexCodetext.SecondaryAndAdditionalData.LotNumber = "LOT123";
            complexCodetext.SecondaryAndAdditionalData.SerialNumber = "SERIAL123";
            complexCodetext.SecondaryAndAdditionalData.DateOfManufacture = DateTime.Now;
            
            //encode HIBC LIC Combined Code
            using (ComplexBarcodeGenerator gen = new ComplexBarcodeGenerator(complexCodetext))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 10;
                gen.Save($"{path}HIBCLICCombined.png");
            }

            //recognize HIBC LIC Combined Code
            using (BarCodeReader reader = new BarCodeReader($"{path}HIBCLICCombined.png", DecodeType.HIBCQRLIC))
            {
                foreach (BarCodeResult result in reader.ReadBarCodes())
                {
                    HIBCLICComplexCodetext codetext = ComplexCodetextReader.TryDecodeHIBCLIC(result.CodeText);
                    HIBCLICCombinedCodetext combinedCodetext = codetext as HIBCLICCombinedCodetext;
                    if (combinedCodetext == null)
                        continue;

                    Console.WriteLine($"Product or catalog number: {combinedCodetext.PrimaryData.ProductOrCatalogNumber}");
                    Console.WriteLine($"Labeler identification code: {combinedCodetext.PrimaryData.LabelerIdentificationCode}");
                    Console.WriteLine($"Unit of measure ID: {combinedCodetext.PrimaryData.UnitOfMeasureID}");
                    Console.WriteLine($"Expiry date: {combinedCodetext.SecondaryAndAdditionalData.ExpiryDate}");
                    Console.WriteLine($"Quantity: {combinedCodetext.SecondaryAndAdditionalData.Quantity}");
                    Console.WriteLine($"Lot number: {combinedCodetext.SecondaryAndAdditionalData.LotNumber}");
                    Console.WriteLine($"Serial number: {combinedCodetext.SecondaryAndAdditionalData.SerialNumber}");
                    Console.WriteLine($"Date of manufacture: {combinedCodetext.SecondaryAndAdditionalData.DateOfManufacture}");
                }
            }
        }
    }
}