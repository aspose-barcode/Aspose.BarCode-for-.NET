//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CodetextLocation : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CodetextLocation:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.Pdf417.Rows = 12;
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //codetext Above
            gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.Above;
            gen.Save($"{path}CodetextLocationAbove.png", BarCodeImageFormat.Png);
            //codetext Below
            gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.Below;
            gen.Save($"{path}CodetextLocationBelow.png", BarCodeImageFormat.Png);
        }
    }
}