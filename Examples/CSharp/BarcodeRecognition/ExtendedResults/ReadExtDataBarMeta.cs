//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtDataBarMeta : ReadExtendedBase
    {
        public static void Run()
        {
            string path = GetWriteFolder();

            //generate Databar with metadata
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DatabarExpandedStacked, "ASPOSE.BARCODE"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.DataBar.Rows = 2;
                gen.Parameters.Barcode.DataBar.Is2DCompositeComponent = true;
                gen.Save($"{path}ExtDataBarMeta.png", BarCodeImageFormat.Png);
            }

            //try to recognize Databar metadata
            Console.WriteLine("ReadExtDataBarMeta:");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtDataBarMeta.png", DecodeType.DatabarExpanded, DecodeType.DatabarExpandedStacked))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"Is2DCompositeComponent:{result.Extended.DataBar.Is2DCompositeComponent}");
                }
            }
        }
    }
}