//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class CodablockFRowCol : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("CodablockFRowCol:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.CodablockF, "Aspose.Barcode");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set CodablockF columns 4
            gen.Parameters.Barcode.Codablock.Columns = 4;
            gen.Parameters.Barcode.Codablock.Rows = 0;
            gen.Save($"{path}CodablockFCol4.png", BarCodeImageFormat.Png);
            //set CodablockF rows 4
            gen.Parameters.Barcode.Codablock.Columns = 0;
            gen.Parameters.Barcode.Codablock.Rows = 4;
            gen.Save($"{path}CodablockFRow4.png", BarCodeImageFormat.Png);
            //set CodablockF columns 4 rows 6
            gen.Parameters.Barcode.Codablock.Columns = 4;
            gen.Parameters.Barcode.Codablock.Rows = 6;
            gen.Save($"{path}CodablockFRow6Col4.png", BarCodeImageFormat.Png);
        }
    }
}