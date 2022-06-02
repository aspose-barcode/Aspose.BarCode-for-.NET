//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CodabarStartStop : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CodabarStartStop:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Codabar, "-12345-");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set start A and stop A
            gen.Parameters.Barcode.Codabar.CodabarStartSymbol = CodabarSymbol.A;
            gen.Parameters.Barcode.Codabar.CodabarStopSymbol = CodabarSymbol.A;
            gen.Save($"{path}CodabarStartAStopA.png", BarCodeImageFormat.Png);
            //set start B and stop B
            gen.Parameters.Barcode.Codabar.CodabarStartSymbol = CodabarSymbol.B;
            gen.Parameters.Barcode.Codabar.CodabarStopSymbol = CodabarSymbol.B;
            gen.Save($"{path}CodabarStartBStopB.png", BarCodeImageFormat.Png);
            //set start C and stop C
            gen.Parameters.Barcode.Codabar.CodabarStartSymbol = CodabarSymbol.C;
            gen.Parameters.Barcode.Codabar.CodabarStopSymbol = CodabarSymbol.C;
            gen.Save($"{path}CodabarStartCStopC.png", BarCodeImageFormat.Png);
            //set start D and stop D
            gen.Parameters.Barcode.Codabar.CodabarStartSymbol = CodabarSymbol.D;
            gen.Parameters.Barcode.Codabar.CodabarStopSymbol = CodabarSymbol.D;
            gen.Save($"{path}CodabarStartDStopD.png", BarCodeImageFormat.Png);
        }
    }
}