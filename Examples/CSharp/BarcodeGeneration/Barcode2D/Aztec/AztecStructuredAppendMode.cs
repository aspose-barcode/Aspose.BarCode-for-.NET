//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecStructuredAppendMode : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecStructuredAppendMode:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, "Aspose"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 15;
                //set Aztec strucutured append mode
                gen.Parameters.Barcode.Aztec.StructuredAppendBarcodeId = 3;
                gen.Parameters.Barcode.Aztec.StructuredAppendBarcodesCount = 5;
                gen.Parameters.Barcode.Aztec.StructuredAppendFileId = "ABCD";
                gen.Save($"{path}AztecStructuredAppendMode.png", BarCodeImageFormat.Png);
            }
        }
	}
}