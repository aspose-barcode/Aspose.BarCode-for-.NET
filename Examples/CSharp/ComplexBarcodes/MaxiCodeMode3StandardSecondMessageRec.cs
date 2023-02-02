//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class MaxiCodeMode3StandardSecondMessageRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeMode3StandardSecondMessageRec:");

            //recognize MaxiCode in mode 3 with standard second message
            using (BarCodeReader reader = new BarCodeReader($"{path}MaxiCodeMode3StandardSecondMessage.png", DecodeType.MaxiCode))
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

                    MaxiCodeStandartSecondMessage secondMessage = maxiCodeStructuredCodetext.SecondMessage as MaxiCodeStandartSecondMessage;
                    if (secondMessage == null)
                        continue;

                    Console.WriteLine("Second message:" + secondMessage.Message);
                }
            }
        }
    }
}