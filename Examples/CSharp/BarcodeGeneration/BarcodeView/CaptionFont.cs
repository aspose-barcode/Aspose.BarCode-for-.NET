//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System.Drawing;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CaptionFont : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CaptionFont:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.Pdf417.Rows = 12;
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.CaptionAbove.Visible = true;
            gen.Parameters.CaptionAbove.Text = "Caption Above";
            //set Caption font
            gen.Parameters.CaptionAbove.Font.FamilyName = "Lucida Handwriting";
            gen.Parameters.CaptionAbove.Font.Style = FontStyle.Underline;
            gen.Parameters.CaptionAbove.Font.Size.Point = 10;
            gen.Save($"{path}CaptionFont.png", BarCodeImageFormat.Png);
        }
	}
}