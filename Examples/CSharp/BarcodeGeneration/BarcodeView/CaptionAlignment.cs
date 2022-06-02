//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CaptionAlignment : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CaptionAlignment:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.Pdf417.Rows = 12;
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.CaptionAbove.Visible = true;
            gen.Parameters.CaptionAbove.Text = "Caption Above";
            gen.Parameters.CaptionAbove.Font.Size.Point = 14;
            //set Caption Above Left alignment
            gen.Parameters.CaptionAbove.Alignment = TextAlignment.Left;
            gen.Save($"{path}CaptionAlignmentLeft.png", BarCodeImageFormat.Png);
            //set Caption Above Center alignment
            gen.Parameters.CaptionAbove.Alignment = TextAlignment.Center;
            gen.Save($"{path}CaptionAlignmentCenter.png", BarCodeImageFormat.Png);
            //set Caption Above Right alignment
            gen.Parameters.CaptionAbove.Alignment = TextAlignment.Right;
            gen.Save($"{path}CaptionAlignmentRight.png", BarCodeImageFormat.Png);
        }
    }
}