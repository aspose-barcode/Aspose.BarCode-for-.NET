//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class OneDBarHeight : OneDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("OneDBarHeight:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "ASPOSE");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set BarHeight 40
            gen.Parameters.Barcode.BarHeight.Pixels = 40;
            gen.Save($"{path}BarHeight40Code128.png", BarCodeImageFormat.Png);
            //set BarHeight 80
            gen.Parameters.Barcode.BarHeight.Pixels = 80;
            gen.Save($"{path}BarHeight80Code128.png", BarCodeImageFormat.Png);
        }
    }
}