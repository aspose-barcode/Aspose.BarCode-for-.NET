//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Pdf417RowColumns : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Pdf417RowColumns:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set 2 columns
            gen.Parameters.Barcode.Pdf417.Columns = 2;
            gen.Save($"{path}Pdf417Columns2.png", BarCodeImageFormat.Png);
            //set 3 rows
            gen.Parameters.Barcode.Pdf417.Columns = 0;
            gen.Parameters.Barcode.Pdf417.Rows = 6;
            gen.Save($"{path}Pdf417Row6.png", BarCodeImageFormat.Png);
            //set 4 columns 9 rows
            gen.Parameters.Barcode.Pdf417.Columns = 4;
            gen.Parameters.Barcode.Pdf417.Rows = 9;
            gen.Save($"{path}Pdf417Row9Columns4.png", BarCodeImageFormat.Png);
        }
    }
}