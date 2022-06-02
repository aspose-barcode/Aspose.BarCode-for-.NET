//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System.Drawing;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class BarcodeColorCodetext : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("BarcodeColorCodetext:");

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
            //set codetext color
            gen.Parameters.Barcode.CodeTextParameters.Color = Color.Green;
            gen.Save($"{path}ColorCodetext.png", BarCodeImageFormat.Png);
        }
	}
}