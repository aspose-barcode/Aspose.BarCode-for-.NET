//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class HIBCLICPrimaryRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("HIBCLICPrimaryRec:");

            //recognize HIBC LIC Code
            using (BarCodeReader reader = new BarCodeReader($"{path}HIBCLICPrimary.png", DecodeType.HIBCQRLIC))
            {
                foreach (BarCodeResult result in reader.ReadBarCodes())
                {
                    HIBCLICComplexCodetext codetext = ComplexCodetextReader.TryDecodeHIBCLIC(result.CodeText);
                    HIBCLICPrimaryDataCodetext primaryDataCodetext = codetext as HIBCLICPrimaryDataCodetext;
                    if (primaryDataCodetext == null)
                        continue;

                    Console.WriteLine($"Product or catalog number: {primaryDataCodetext.Data.ProductOrCatalogNumber}");
                    Console.WriteLine($"Labeler identification code: {primaryDataCodetext.Data.LabelerIdentificationCode}");
                    Console.WriteLine($"Unit of measure ID: {primaryDataCodetext.Data.UnitOfMeasureID}");
                }
            }
        }
    }
}