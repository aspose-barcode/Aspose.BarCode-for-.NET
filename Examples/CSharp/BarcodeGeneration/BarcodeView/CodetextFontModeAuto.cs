//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System.Drawing;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CodetextFontModeAuto : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CodetextFontModeAuto:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.Pdf417.Rows = 12;
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //automatic font set
            gen.Parameters.Barcode.CodeTextParameters.FontMode = FontMode.Auto;
            gen.Parameters.Barcode.CodeTextParameters.Font.FamilyName = "Lucida Handwriting";
            gen.Parameters.Barcode.CodeTextParameters.Font.Style = FontStyle.Underline;
            //font size is ignored
            gen.Parameters.Barcode.CodeTextParameters.Font.Size.Point = 10;
            gen.Save($"{path}CodetextFontModeAuto.png", BarCodeImageFormat.Png);
        }
	}
}