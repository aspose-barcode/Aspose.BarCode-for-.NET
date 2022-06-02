//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadExtUnicodeCodeText : ReadExtendedBase
    {
		public static void Run()
        {
            string path = GetWriteFolder();
            Console.OutputEncoding = Encoding.Unicode;

            //create encoded Unicode codetext
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "Aspose常に先を行く"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Parameters.Barcode.DataMatrix.CodeTextEncoding = Encoding.UTF8;
                gen.Save($"{path}ExtUnicodeCodeText.png", BarCodeImageFormat.Png);
            }

            //try to recognize Unicode codetext
            Console.WriteLine("ReadExtUnicodeCodeText:");
            using (BarCodeReader read = new BarCodeReader($"{path}ExtUnicodeCodeText.png", DecodeType.DataMatrix))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeTypeName:{result.CodeTypeName}");
                    Console.WriteLine($"GetCodeText:{result.GetCodeText(Encoding.UTF8)}");
                }
        }
	}
}