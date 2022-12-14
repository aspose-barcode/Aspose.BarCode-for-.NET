//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class HIBCPASGenRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("HIBCPASGenRec:");

            //create HIBC PAS Code
            HIBCPASCodetext complexCodetext = new HIBCPASCodetext();
            complexCodetext.BarcodeType = EncodeTypes.HIBCDataMatrixPAS;
            complexCodetext.DataLocation = HIBCPASDataLocation.Patient;
            complexCodetext.AddRecord(HIBCPASDataType.LabelerIdentificationCode, "A123");
            complexCodetext.AddRecord(HIBCPASDataType.ManufacturerSerialNumber, "SERIAL123");
            
            //encode HIBC PAS Code
            using (ComplexBarcodeGenerator gen = new ComplexBarcodeGenerator(complexCodetext))
            {
                gen.Save($"{path}HIBCPAS.png");
            }

            //recognize HIBC PAS Code
            using (BarCodeReader reader = new BarCodeReader($"{path}HIBCPAS.png", DecodeType.HIBCQRLIC))
            {
                foreach (BarCodeResult result in reader.ReadBarCodes())
                {
                    HIBCPASCodetext codetext = ComplexCodetextReader.TryDecodeHIBCPAS(result.CodeText);
                    if (codetext == null)
                        continue;

                    Console.WriteLine($"Data location: {codetext.DataLocation}");
                    foreach (HIBCPASRecord record in codetext.GetRecords())
                    {
                        Console.Write($"Data type: {record.DataType}. ");
                        Console.WriteLine($"Data: {record.Data}.");
                    }
                }
            }
        }
    }
}