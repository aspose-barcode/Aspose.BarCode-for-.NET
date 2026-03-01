//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Gs1DataMatrixExample : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Gs1DataMatrixExample:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1DataMatrix, "(01)12345678901231(21)ASPOSE(30)9876");
            gen.Parameters.Barcode.XDimension.Pixels = 8;
            gen.Parameters.Barcode.DataMatrix.Version = DataMatrixVersion.ECC200_12x36;
            gen.Save($"{path}Gs1DataMatrixExample.png", BarCodeImageFormat.Png);
        }
    }
}