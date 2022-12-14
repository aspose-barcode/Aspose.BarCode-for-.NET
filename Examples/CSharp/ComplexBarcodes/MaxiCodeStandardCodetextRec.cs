//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.ComplexBarcode;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.ComplexBarcodes
{
    internal class MaxiCodeStandardCodetextRec : ComplexBarcodesBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeStandardCodetextRec:");

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