//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class MaxiCodeMode2StandardSecondMessageGenRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeMode2StandardSecondMessageGenRec:");

            //create MaxiCode in mode 2 with standard second message
            MaxiCodeCodetextMode2 maxiCodeCodetext = new MaxiCodeCodetextMode2();
            maxiCodeCodetext.PostalCode = "524032140";
            maxiCodeCodetext.CountryCode = 056;
            maxiCodeCodetext.ServiceCategory = 999;

            //create standard second message
            MaxiCodeStandartSecondMessage maxiCodeStandartSecondMessage = new MaxiCodeStandartSecondMessage();
            maxiCodeStandartSecondMessage.Message = "Second message";
            maxiCodeCodetext.SecondMessage = maxiCodeStandartSecondMessage;

            //encode message
            using (ComplexBarcodeGenerator complexGenerator = new ComplexBarcodeGenerator(maxiCodeCodetext))
            {
                complexGenerator.Save($"{path}MaxiCodeMode2StandardSecondMessage.png");
            }

            //recognize MaxiCode in mode 2 with standard second message
            using (BarCodeReader reader = new BarCodeReader($"{path}MaxiCodeMode2StandardSecondMessage.png", DecodeType.MaxiCode))
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

                    MaxiCodeStandartSecondMessage secondMessage = maxiCodeStructuredCodetext.SecondMessage as MaxiCodeStandartSecondMessage;
                    if (secondMessage == null)
                        continue;

                    Console.WriteLine("Second message:" + secondMessage.Message);
                }
            }
        }
    }
}