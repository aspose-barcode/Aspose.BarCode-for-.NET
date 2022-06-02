//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System.Drawing;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class BarcodeColorCaption : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("BarcodeColorCaption:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.Pdf417.Rows = 6;
            gen.Parameters.Barcode.XDimension.Pixels = 3;
            gen.Parameters.CaptionAbove.Visible = true;
            gen.Parameters.CaptionAbove.Font.Size.Point = 20;
            gen.Parameters.CaptionAbove.Text = "Caption Above";
            gen.Parameters.CaptionBelow.Visible = true;
            gen.Parameters.CaptionBelow.Font.Size.Point = 20;
            gen.Parameters.CaptionBelow.Text = "Caption Below";
            gen.Parameters.Border.Visible = true;
            gen.Parameters.Border.Width.Pixels = 5;
            //set Caption Above color
            gen.Parameters.CaptionAbove.TextColor = Color.Green;
            gen.Save($"{path}ColorCaptionAbove.png", BarCodeImageFormat.Png);
            //set Caption Below color
            gen.Parameters.CaptionAbove.TextColor = Color.Black;
            gen.Parameters.CaptionBelow.TextColor = Color.Green;
            gen.Save($"{path}ColorCaptionBelow.png", BarCodeImageFormat.Png);
        }
    }
}