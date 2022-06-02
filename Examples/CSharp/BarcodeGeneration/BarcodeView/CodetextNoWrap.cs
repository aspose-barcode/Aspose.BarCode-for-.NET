//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CodetextNoWrap : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CodetextNoWrap:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Extremely long codetext for one row");
            gen.Parameters.Barcode.Pdf417.Rows = 12;
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.CodeTextParameters.FontMode = FontMode.Manual;
            gen.Parameters.Barcode.CodeTextParameters.Font.Size.Point = 12;
            //text wrapapping mode on
            gen.Parameters.Barcode.CodeTextParameters.NoWrap = false;
            gen.Save($"{path}CodetextLongTextWrap.png", BarCodeImageFormat.Png);
            //text wrapapping mode off
            gen.Parameters.Barcode.CodeTextParameters.NoWrap = true;
            gen.Save($"{path}CodetextLongTextNoWrap.png", BarCodeImageFormat.Png);
        }
    }
}