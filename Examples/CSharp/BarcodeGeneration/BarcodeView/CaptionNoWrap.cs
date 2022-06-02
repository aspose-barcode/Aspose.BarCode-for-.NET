//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CaptionNoWrap : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CaptionNoWrap:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.Pdf417.Rows = 12;
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.CaptionAbove.Visible = true;
            gen.Parameters.CaptionAbove.Text = "Caption Above";
            gen.Parameters.CaptionAbove.Font.Size.Point = 28;
            //set wrapping Caption text mode
            gen.Parameters.CaptionAbove.NoWrap = false;
            gen.Save($"{path}CaptionTextWrap.png", BarCodeImageFormat.Png);
            //set no wrapping Caption text mode
            gen.Parameters.CaptionAbove.NoWrap = true;
            gen.Save($"{path}CaptionTextNoWrap.png", BarCodeImageFormat.Png);
        }
    }
}