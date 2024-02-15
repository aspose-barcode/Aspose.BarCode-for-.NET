//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MicroPdf417RowColumns : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MicroPdf417RowColumns:");
            
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MicroPdf417, "ASPOSE");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set 2 columns
            gen.Parameters.Barcode.Pdf417.Columns = 2;
            gen.Save($"{path}MicroPdf417Columns2.png", BarCodeImageFormat.Png);
            //set 3 rows
            gen.Parameters.Barcode.Pdf417.Columns = 0;
            gen.Parameters.Barcode.Pdf417.Rows = 6;
            gen.Save($"{path}MicroPdf417Row6.png", BarCodeImageFormat.Png);
            //set 4 columns 9 rows
            gen.Parameters.Barcode.Pdf417.Columns = 4;
            gen.Parameters.Barcode.Pdf417.Rows = 8;
            gen.Save($"{path}MicroPdf417Row8Columns4.png", BarCodeImageFormat.Png);
        }
	}
}