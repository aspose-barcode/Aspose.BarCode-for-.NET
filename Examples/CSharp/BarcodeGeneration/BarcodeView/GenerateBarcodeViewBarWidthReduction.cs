//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeViewBarWidthReduction : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeViewBarWidthReduction:");

            //Code 128
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "ASPOSE");
            gen.Parameters.Barcode.XDimension.Pixels = 5;
            //Code 128 without barwidth rediction
            gen.Parameters.Barcode.BarWidthReduction.Pixels = 0;
            gen.Save($"{path}Code128BarWidthReduction0.png", BarCodeImageFormat.Png);
            //Code 128 with 2 pix barwidth rediction
            gen.Parameters.Barcode.BarWidthReduction.Pixels = 3;
            gen.Save($"{path}Code128BarWidthReduction3.png", BarCodeImageFormat.Png);
            
            //DataMatrix
            gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "ASPOSE");
            gen.Parameters.Barcode.XDimension.Pixels = 10;
            //DataMatrix without barwidth rediction
            gen.Parameters.Barcode.BarWidthReduction.Pixels = 0;
            gen.Save($"{path}DataMatrixBarWidthReduction0.png", BarCodeImageFormat.Png);
            //DataMatrix with 4 pix barwidth rediction
            gen.Parameters.Barcode.BarWidthReduction.Pixels = 4;
            gen.Save($"{path}DataMatrixBarWidthReduction4.png", BarCodeImageFormat.Png);
        }
    }
}