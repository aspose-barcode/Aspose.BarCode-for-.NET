//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class MaxiCodeMode3StructuredSecondMessageRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeMode3StructuredSecondMessageGenRec:");

            //recognize MaxiCode in mode 3 with structured second message
            using (BarCodeReader reader = new BarCodeReader($"{path}MaxiCodeMode3StructuredSecondMessage.png", DecodeType.MaxiCode))
            {
                foreach (BarCodeResult result in reader.ReadBarCodes())
                {
                    MaxiCodeCodetext complexCodetext = ComplexCodetextReader.TryDecodeMaxiCode(result.Extended.MaxiCode.MaxiCodeMode, result.CodeText);
                    MaxiCodeCodetextMode3 maxiCodeStructuredCodetext = complexCodetext as MaxiCodeCodetextMode3;
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