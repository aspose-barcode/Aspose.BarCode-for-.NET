//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecSymbolModeExample : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecSymbolModeExample:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                //set symbol mode Auto
                gen.CodeText = "Åspóse.Barcóde©";
                gen.Parameters.Barcode.Aztec.AztecSymbolMode = AztecSymbolMode.Auto;
                gen.Save($"{path}AztecSymbolModeAuto.png", BarCodeImageFormat.Png);
                //set symbol mode FullRange
                gen.CodeText = "Åspóse.Barcóde©";
                gen.Parameters.Barcode.Aztec.AztecSymbolMode = AztecSymbolMode.FullRange;
                gen.Save($"{path}AztecSymbolModeFullRange.png", BarCodeImageFormat.Png);
                //set symbol mode Compact
                gen.CodeText = "Åspóse.Barcóde©";
                gen.Parameters.Barcode.Aztec.AztecSymbolMode = AztecSymbolMode.Compact;
                gen.Save($"{path}AztecSymbolModeCompact.png", BarCodeImageFormat.Png);
                //set symbol mode Auto
                gen.CodeText = "123";
                gen.Parameters.Barcode.Aztec.AztecSymbolMode = AztecSymbolMode.Rune;
                gen.Save($"{path}AztecSymbolModeRune.png", BarCodeImageFormat.Png);
            }
        }
    }
}