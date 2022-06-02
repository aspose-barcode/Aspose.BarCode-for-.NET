//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CaptionPadding : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CaptionPadding:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.Pdf417.Rows = 12;
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.CaptionAbove.Visible = true;
            gen.Parameters.CaptionAbove.Text = "Caption Above";
            gen.Parameters.CaptionAbove.Font.Size.Point = 14;
            //Set all padding around the Caption to 5 pixels
            gen.Parameters.CaptionAbove.Padding.Left.Pixels = 5;
            gen.Parameters.CaptionAbove.Padding.Top.Pixels = 5;
            gen.Parameters.CaptionAbove.Padding.Right.Pixels = 5;
            gen.Parameters.CaptionAbove.Padding.Bottom.Pixels = 5;
            gen.Save($"{path}CaptionPadding5Pixels.png", BarCodeImageFormat.Png);
            //Set all padding around the Caption to 40 pixels
            gen.Parameters.CaptionAbove.Padding.Left.Pixels = 40;
            gen.Parameters.CaptionAbove.Padding.Top.Pixels = 40;
            gen.Parameters.CaptionAbove.Padding.Right.Pixels = 40;
            gen.Parameters.CaptionAbove.Padding.Bottom.Pixels = 40;
            gen.Save($"{path}CaptionPadding40Pixels.png", BarCodeImageFormat.Png);
        }
    }
}