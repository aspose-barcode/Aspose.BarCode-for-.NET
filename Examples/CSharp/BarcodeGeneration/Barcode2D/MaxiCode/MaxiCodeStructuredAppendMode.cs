//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MaxiCodeStructuredAppendMode : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeStructuredAppendMode:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MaxiCode, "Aspose"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 15;
                //set MaxiCode strucutured append mode
                gen.Parameters.Barcode.MaxiCode.MaxiCodeStructuredAppendModeBarcodeId = 3;
                gen.Parameters.Barcode.MaxiCode.MaxiCodeStructuredAppendModeBarcodeId = 5;
                gen.Save($"{path}MaxiCodeStructuredAppendMode.png", BarCodeImageFormat.Png);
            }
        }
	}
}