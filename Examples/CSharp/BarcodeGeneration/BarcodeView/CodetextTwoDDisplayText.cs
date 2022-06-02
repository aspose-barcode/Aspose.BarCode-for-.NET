//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CodetextTwoDDisplayText : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CodetextTwoDDisplayText:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.Pdf417.Rows = 12;
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //replace visible codetext for 2D barcodes: Aztec, Pdf417, DataMatrix, QR, MaxiCode, DotCode
            gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Replace Codetext";
            gen.Save($"{path}CodetextTwoDDisplayText.png", BarCodeImageFormat.Png);
        }
	}
}