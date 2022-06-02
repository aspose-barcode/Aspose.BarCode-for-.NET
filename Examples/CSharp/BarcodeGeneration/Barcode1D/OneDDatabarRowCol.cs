//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class OneDDatabarRowCol : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("OneDDatabarRowCol:");

            //set 4 columns
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DatabarExpandedStacked, "Databar Expanded Stacked long");
            gen.Parameters.Barcode.DataBar.Columns = 4;
            gen.Save($"{path}DatabarCols4.png", BarCodeImageFormat.Png);
            //set 3 rows
            gen = new BarcodeGenerator(EncodeTypes.DatabarExpandedStacked, "Databar Expanded Stacked long");
            gen.Parameters.Barcode.DataBar.Rows = 3;
            gen.Save($"{path}DatabarRows3.png", BarCodeImageFormat.Png);
            //set 6 columns 10 rows
            gen = new BarcodeGenerator(EncodeTypes.DatabarExpandedStacked, "Databar Expanded Stacked long");
            gen.Parameters.Barcode.DataBar.Columns = 6;
            gen.Parameters.Barcode.DataBar.Rows = 10;
            gen.Save($"{path}DatabarCols6Rows10.png", BarCodeImageFormat.Png);
        }
    }
}