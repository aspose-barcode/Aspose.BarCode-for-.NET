//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecLayersCount : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecLayersCount:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                //set layers count to 15
                gen.Parameters.Barcode.Aztec.LayersCount = 15;
                gen.Save($"{path}AztecLayersCount.png", BarCodeImageFormat.Png);
            }
        }
    }
}