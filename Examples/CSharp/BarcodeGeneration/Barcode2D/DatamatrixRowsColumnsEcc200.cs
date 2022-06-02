//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DatamatrixRowsColumnsEcc200 : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DatamatrixRowsColumnsEcc200:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            //set ECC type to Ecc200
            gen.Parameters.Barcode.DataMatrix.DataMatrixEcc = DataMatrixEccType.Ecc200;
            //set rows 22 columns 22
            gen.Parameters.Barcode.DataMatrix.Columns = 22;
            gen.Parameters.Barcode.DataMatrix.Rows = 22;
            gen.Save($"{path}DatamatrixRows22Columns22Ecc200.png", BarCodeImageFormat.Png);
            //set rows 12 columns 36
            gen.Parameters.Barcode.DataMatrix.Columns = 36;
            gen.Parameters.Barcode.DataMatrix.Rows = 12;
            gen.Save($"{path}DatamatrixRows12Columns36Ecc200.png", BarCodeImageFormat.Png);
        }
	}
}