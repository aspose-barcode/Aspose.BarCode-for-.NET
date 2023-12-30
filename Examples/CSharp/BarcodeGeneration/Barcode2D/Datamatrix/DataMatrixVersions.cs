//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DataMatrixVersions : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DataMatrixVersions:");

            using (BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.DataMatrix, "Åspóse.Barcóde©"))
            {
                generator.Parameters.Barcode.XDimension.Pixels = 4;
                //set ECC type to Ecc200
                generator.Parameters.Barcode.DataMatrix.DataMatrixEcc = DataMatrixEccType.Ecc200;
                //set rows 22 columns 22
                generator.Parameters.Barcode.DataMatrix.DataMatrixVersion = DataMatrixVersion.ECC200_22x22;
                generator.Save($"{path}DataMatrixRows22Columns22Ecc200.png", BarCodeImageFormat.Png);
                //set rows 12 columns 64
                generator.Parameters.Barcode.DataMatrix.DataMatrixVersion = DataMatrixVersion.DMRE_12x64;
                generator.Save($"{path}DataMatrixRows12Columns64Ecc200.png", BarCodeImageFormat.Png);

                //set ECC type to Ecc140
                generator.Parameters.Barcode.DataMatrix.DataMatrixEcc = DataMatrixEccType.Ecc140;
                //set rows 29 columns 29
                generator.Parameters.Barcode.DataMatrix.DataMatrixVersion = DataMatrixVersion.ECC000_140_29x29;
                generator.Save($"{path}DataMatrixRows29Columns29Ecc140.png", BarCodeImageFormat.Png);
            }
        }
	}
}