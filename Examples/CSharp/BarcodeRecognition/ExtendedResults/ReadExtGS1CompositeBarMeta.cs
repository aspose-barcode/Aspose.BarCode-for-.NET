//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtGS1CompositeBarMeta : ReadExtendedBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.OutputEncoding = Encoding.Unicode;

            //generate GS1CompositeBar with metadata

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106(3202)012345|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_C;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;

                gen.Save($"{path}ExtGS1CompositeBarMeta.png", BarCodeImageFormat.Png);
            }

            //try to recognize Aztec metadata
            Console.WriteLine("ReadExtGS1CompositeBarMeta:");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtGS1CompositeBarMeta.png", DecodeType.GS1CompositeBar))
            {
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                    Console.WriteLine($"OneDType:{result.Extended.GS1CompositeBar.OneDType.ToString()}");
                    Console.WriteLine($"OneDCodeText:{result.Extended.GS1CompositeBar.OneDCodeText}");
                    Console.WriteLine($"TwoDType:{result.Extended.GS1CompositeBar.TwoDType.ToString()}");
                    Console.WriteLine($"TwoDCodeText:{result.Extended.GS1CompositeBar.TwoDCodeText}");
                }
            }
        }
    }
}