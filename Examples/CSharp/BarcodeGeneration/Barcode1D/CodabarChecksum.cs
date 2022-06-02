//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CodabarChecksum : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CodabarChecksum:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Codabar, "-12345-");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set None checksum
            gen.Parameters.Barcode.IsChecksumEnabled = EnableChecksum.Default;
            gen.Save($"{path}CodabarChecksumNone.png", BarCodeImageFormat.Png);
            //set Mod10 checksum
            gen.Parameters.Barcode.IsChecksumEnabled = EnableChecksum.Yes;
            gen.Parameters.Barcode.Codabar.CodabarChecksumMode = CodabarChecksumMode.Mod10;
            gen.Save($"{path}CodabarChecksumMod10.png", BarCodeImageFormat.Png);
            //set Mod16 checksum
            gen.Parameters.Barcode.IsChecksumEnabled = EnableChecksum.Yes;
            gen.Parameters.Barcode.Codabar.CodabarChecksumMode = CodabarChecksumMode.Mod16;
            gen.Save($"{path}CodabarChecksumMod16.png", BarCodeImageFormat.Png);
        }
    }
}