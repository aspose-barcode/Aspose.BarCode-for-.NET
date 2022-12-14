//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class MaxiCodeStandardCodetextGenRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeStandardCodetextGenRec:");

            MaxiCodeStandardCodetext maxiCodeCodetext = new MaxiCodeStandardCodetext();
            maxiCodeCodetext.Mode = MaxiCodeMode.Mode4;
            maxiCodeCodetext.Message = "MaxiCode standard codetext";

            //encode message
            using (ComplexBarcodeGenerator complexGenerator = new ComplexBarcodeGenerator(maxiCodeCodetext))
            {
                complexGenerator.Save($"{path}MaxiCodeStandardCodetext.png");
            }

            //recognize MaxiCode with standard codetext
            using (BarCodeReader reader = new BarCodeReader($"{path}MaxiCodeStandardCodetext.png", DecodeType.MaxiCode))
            {
                foreach (BarCodeResult result in reader.ReadBarCodes())
                {
                    MaxiCodeCodetext complexCodetext = ComplexCodetextReader.TryDecodeMaxiCode(result.Extended.MaxiCode.MaxiCodeMode, result.CodeText);
                    MaxiCodeStandardCodetext maxiCodeStandardCodetext = complexCodetext as MaxiCodeStandardCodetext;
                    if (maxiCodeStandardCodetext == null)
                        continue;

                    Console.WriteLine("MaxiCode codetext:" + maxiCodeStandardCodetext.Message);
                }
            }
        }
    }
}