//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DotCodeRowsColumns : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DotCodeRowsColumns:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DotCode, "Aspose"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 10;
                //set columns 18
                gen.Parameters.Barcode.DotCode.Columns = 18;
                gen.Save($"{path}DotCodeColumns18.png", BarCodeImageFormat.Png);
                //set rows 12
                gen.Parameters.Barcode.DotCode.Columns = -1;
                gen.Parameters.Barcode.DotCode.Rows = 12;
                gen.Save($"{path}DotCodeRows12.png", BarCodeImageFormat.Png);
                //set rows 20 columns 29
                gen.Parameters.Barcode.DotCode.Columns = 29;
                gen.Parameters.Barcode.DotCode.Rows = 26;
                gen.Save($"{path}DotCodeRows26Columns29.png", BarCodeImageFormat.Png);
            }
        }
	}
}