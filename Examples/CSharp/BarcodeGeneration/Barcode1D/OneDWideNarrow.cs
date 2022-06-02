//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class OneDWideNarrow : OneDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("OneDWideNarrow:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code39Extended, "ASPOSE");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set Wide/Narrow Ratio to 2
            gen.Parameters.Barcode.WideNarrowRatio = 2;
            gen.Save($"{path}WideNarrow2Code39.png", BarCodeImageFormat.Png);
            //set Wide/Narrow Ratio to 5
            gen.Parameters.Barcode.WideNarrowRatio = 5;
            gen.Save($"{path}WideNarrow5Code39.png", BarCodeImageFormat.Png);
        }
    }
}