//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Pdf417Compaction : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Pdf417Compaction:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.Below;
            gen.Parameters.Barcode.Pdf417.Columns = 3;
            //Set compaction mode to Auto
            gen.Parameters.Barcode.Pdf417.Pdf417CompactionMode = Pdf417CompactionMode.Auto;
            gen.CodeText = "Åspóse.Barcóde©";
            gen.Save($"{path}Pdf417CompactionAuto.png", BarCodeImageFormat.Png);
            //Set compaction mode to Binary
            gen.Parameters.Barcode.Pdf417.Pdf417CompactionMode = Pdf417CompactionMode.Binary;
            gen.CodeText = "Åspóse.Barcóde©";
            gen.Save($"{path}Pdf417CompactionBinary.png", BarCodeImageFormat.Png);
            //Set compaction mode to Text
            gen.Parameters.Barcode.Pdf417.Pdf417CompactionMode = Pdf417CompactionMode.Text;
            gen.CodeText = "ASPOSE";
            gen.Save($"{path}Pdf417CompactionText.png", BarCodeImageFormat.Png);
            //Set compaction mode to Numeric
            gen.Parameters.Barcode.Pdf417.Pdf417CompactionMode = Pdf417CompactionMode.Numeric;
            gen.CodeText = "1234567890";
            gen.Save($"{path}Pdf417CompactionNumeric.png", BarCodeImageFormat.Png);
        }
    }
}