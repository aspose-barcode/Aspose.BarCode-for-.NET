//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class ITF14BorderThickness : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("ITF14BorderThickness:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.ITF14, "12345678901231");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.ITF.ItfBorderType = ITF14BorderType.Frame;
            //ITF border size 5 Pixels
            gen.Parameters.Barcode.ITF.ItfBorderThickness.Pixels = 5;
            gen.Save($"{path}ITF14BorderSize5Pixels.png", BarCodeImageFormat.Png);
            //ITF border size 15 Pixels
            gen.Parameters.Barcode.ITF.ItfBorderThickness.Pixels = 15;
            gen.Save($"{path}ITF14BorderSize15Pixels.png", BarCodeImageFormat.Png);
        }
    }
}