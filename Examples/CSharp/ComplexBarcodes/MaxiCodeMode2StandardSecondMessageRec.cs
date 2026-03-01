//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class MaxiCodeMode2StandardSecondMessageRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeMode2StandardSecondMessageRec:");

            //recognize MaxiCode in mode 2 with standard second message
            using (BarCodeReader reader = new BarCodeReader($"{path}MaxiCodeMode2StandardSecondMessage.png", DecodeType.MaxiCode))
            {
                foreach (BarCodeResult result in reader.ReadBarCodes())
                {
                    MaxiCodeCodetext complexCodetext = ComplexCodetextReader.TryDecodeMaxiCode(result.Extended.MaxiCode.Mode, result.CodeText);
                    MaxiCodeCodetextMode2 maxiCodeStructuredCodetext = complexCodetext as MaxiCodeCodetextMode2;
                    if (maxiCodeStructuredCodetext == null)
                        continue;

                    Console.WriteLine("PostalCode: " + maxiCodeStructuredCodetext.PostalCode);
                    Console.WriteLine("CountryCode: " + maxiCodeStructuredCodetext.CountryCode);
                    Console.WriteLine("ServiceCategory: " + maxiCodeStructuredCodetext.ServiceCategory);

                    MaxiCodeStandardSecondMessage secondMessage = maxiCodeStructuredCodetext.SecondMessage as MaxiCodeStandardSecondMessage;
                    if (secondMessage == null)
                        continue;

                    Console.WriteLine("Second message:" + secondMessage.Message);
                }
            }
        }
    }
}