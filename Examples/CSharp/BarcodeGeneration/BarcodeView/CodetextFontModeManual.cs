//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;
#if NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_1_OR_GREATER
using Aspose.Drawing;
#else
using System.Drawing;
#endif

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CodetextFontModeManual : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CodetextFontModeManual:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.Pdf417.Rows = 12;
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //manual font set
            gen.Parameters.Barcode.CodeTextParameters.FontMode = FontMode.Manual;
            gen.Parameters.Barcode.CodeTextParameters.Font.FamilyName = "Lucida Handwriting";
            gen.Parameters.Barcode.CodeTextParameters.Font.Style = FontStyle.Underline;
            //font size is set
            gen.Parameters.Barcode.CodeTextParameters.Font.Size.Point = 10;
            gen.Save($"{path}CodetextFontModeManual.png", BarCodeImageFormat.Png);
        }
	}
}