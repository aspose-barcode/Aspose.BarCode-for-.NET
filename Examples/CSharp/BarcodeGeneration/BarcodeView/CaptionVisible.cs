//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CaptionVisible : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CaptionVisible:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.Pdf417.Rows = 12;
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set Caption Above visible
            gen.Parameters.CaptionAbove.Visible = true;
            gen.Parameters.CaptionAbove.Text = "Caption Above";
            gen.Parameters.CaptionAbove.Font.Size.Point = 14;
            gen.Save($"{path}CaptionVisibleAbove.png", BarCodeImageFormat.Png);
            gen.Parameters.CaptionAbove.Visible = false;
            //set Caption Below visible
            gen.Parameters.CaptionBelow.Visible = true;
            gen.Parameters.CaptionBelow.Text = "Caption Below";
            gen.Parameters.CaptionBelow.Font.Size.Point = 14;
            gen.Save($"{path}CaptionVisibleBelow.png", BarCodeImageFormat.Png);
        }
    }
}