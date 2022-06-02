//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtCode128Meta : ReadExtendedBase
    {
        public static void Run()
        {
            string path = GetWriteFolder();

            //generate Code128 with metadata
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "Aspose1234"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Save($"{path}Code128.png", BarCodeImageFormat.Png);
            }

            //try to recognize Code128 with data portions
            Console.WriteLine("ReadExtCode128Meta:");
            using (BarCodeReader read = new BarCodeReader($"{path}Code128.png", DecodeType.Code128))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    string data = "";
                    foreach (Code128DataPortion portion in result.Extended.Code128.Code128DataPortions)
                        data += "Type{" + portion.Code128SubType.ToString() +"}, Data{" + portion.Data + "};";
                    Console.WriteLine($"Code128DataPortions:{data}");
                }
            }
        }
    }
}