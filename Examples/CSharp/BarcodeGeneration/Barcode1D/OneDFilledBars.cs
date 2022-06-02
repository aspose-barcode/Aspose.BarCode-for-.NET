//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class OneDFilledBars : OneDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("OneDFilledBars:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "ASPOSE");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set bars filled
            gen.Parameters.Barcode.FilledBars = true;
            gen.Save($"{path}BarsFilledCode128.png", BarCodeImageFormat.Png);
            //set bars empty
            gen.Parameters.Barcode.FilledBars = false;
            gen.Save($"{path}BarsEmptyCode128.png", BarCodeImageFormat.Png);
        }
    }
}