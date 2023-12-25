//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecErrorLevelExample : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecErrorLevelExample:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, "Åspóse.Barcóde© is a powerful library to generate & recognize 1D & 2D barcodes"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Parameters.Barcode.Aztec.AztecSymbolMode = AztecSymbolMode.FullRange;
                //set error correction capacity to 5%
                gen.Parameters.Barcode.Aztec.AztecErrorLevel = 5;
                gen.Save($"{path}AztecErrorLevel5.png", BarCodeImageFormat.Png);
                //set error correction capacity to 50%
                gen.Parameters.Barcode.Aztec.AztecErrorLevel = 50;
                gen.Save($"{path}AztecErrorLevel50.png", BarCodeImageFormat.Png);
            }
        }
    }
}