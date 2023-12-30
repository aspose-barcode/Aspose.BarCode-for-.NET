//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DotCodeStructuredAppendMode : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DotCodeStructuredAppendMode:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DotCode, "Aspose"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 10;
                //set DotCode strucutured append mode
                gen.Parameters.Barcode.DotCode.DotCodeStructuredAppendModeBarcodeId = 3;
                gen.Parameters.Barcode.DotCode.DotCodeStructuredAppendModeBarcodesCount = 5;
                gen.Save($"{path}DotCodeStructuredAppendMode.png", BarCodeImageFormat.Png);
            }
        }
    }
}