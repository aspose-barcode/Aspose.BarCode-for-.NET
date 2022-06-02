//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class ITF14BorderTypeGen : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("ITF14BorderTypeGen:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.ITF14, "12345678901231");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //ITF border type None
            gen.Parameters.Barcode.ITF.ItfBorderType = ITF14BorderType.None;
            gen.Save($"{path}ITF14BorderNone.png", BarCodeImageFormat.Png);
            //ITF border type Bar
            gen.Parameters.Barcode.ITF.ItfBorderType = ITF14BorderType.Bar;
            gen.Save($"{path}ITF14BorderBar.png", BarCodeImageFormat.Png);
            //ITF border type BarOut
            gen.Parameters.Barcode.ITF.ItfBorderType = ITF14BorderType.BarOut;
            gen.Save($"{path}ITF14BorderBarOut.png", BarCodeImageFormat.Png);
            //ITF border type Frame
            gen.Parameters.Barcode.ITF.ItfBorderType = ITF14BorderType.Frame;
            gen.Save($"{path}ITF14BorderFrame.png", BarCodeImageFormat.Png);
            //ITF border type FrameOut
            gen.Parameters.Barcode.ITF.ItfBorderType = ITF14BorderType.FrameOut;
            gen.Save($"{path}ITF14BorderFrameOut.png", BarCodeImageFormat.Png);
        }
    }
}