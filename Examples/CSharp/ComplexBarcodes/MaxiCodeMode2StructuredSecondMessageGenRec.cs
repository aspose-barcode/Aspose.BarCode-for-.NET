//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class MaxiCodeMode2StructuredSecondMessageGenRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeMode2StructuredSecondMessageGenRec:");

            //create MaxiCode in mode 2 with structured second message
            MaxiCodeCodetextMode2 maxiCodeCodetext = new MaxiCodeCodetextMode2();
            maxiCodeCodetext.PostalCode = "524032140";
            maxiCodeCodetext.CountryCode = 056;
            maxiCodeCodetext.ServiceCategory = 999;

            //create structured second message
            MaxiCodeStructuredSecondMessage maxiCodeStructuredSecondMessage = new MaxiCodeStructuredSecondMessage();
            maxiCodeStructuredSecondMessage.Add("634 ALPHA DRIVE");
            maxiCodeStructuredSecondMessage.Add("PITTSBURGH");
            maxiCodeStructuredSecondMessage.Add("PA");
            maxiCodeStructuredSecondMessage.Year = 99;
            maxiCodeCodetext.SecondMessage = maxiCodeStructuredSecondMessage;

            //encode message
            using (ComplexBarcodeGenerator complexGenerator = new ComplexBarcodeGenerator(maxiCodeCodetext))
            {
                complexGenerator.Save($"{path}MaxiCodeMode2StructuredSecondMessage.png");
            }

            //recognize MaxiCode in mode 2 with structured second message
            using (BarCodeReader reader = new BarCodeReader($"{path}MaxiCodeMode2StructuredSecondMessage.png", DecodeType.MaxiCode))
            {
                foreach (BarCodeResult result in reader.ReadBarCodes())
                {
                    MaxiCodeCodetext complexCodetext = ComplexCodetextReader.TryDecodeMaxiCode(result.Extended.MaxiCode.MaxiCodeMode, result.CodeText);
                    MaxiCodeCodetextMode2 maxiCodeStructuredCodetext = complexCodetext as MaxiCodeCodetextMode2;
                    if (maxiCodeStructuredCodetext == null)
                        continue;

                    Console.WriteLine("PostalCode: " + maxiCodeStructuredCodetext.PostalCode);
                    Console.WriteLine("CountryCode: " + maxiCodeStructuredCodetext.CountryCode);
                    Console.WriteLine("ServiceCategory: " + maxiCodeStructuredCodetext.ServiceCategory);

                    MaxiCodeStructuredSecondMessage secondMessage = maxiCodeStructuredCodetext.SecondMessage as MaxiCodeStructuredSecondMessage;
                    if (secondMessage == null)
                        continue;

                    Console.WriteLine("Second message:");
                    foreach (string identifier in secondMessage.Identifiers)
                    {
                        Console.WriteLine(identifier);
                    }
                }
            }
        }
    }
}