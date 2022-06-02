//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class PostalOneCode  : PostalBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("PostalOneCode:");

            BarcodeGenerator gen = null;
            //create OneCode with 20 digits
            gen = new BarcodeGenerator(EncodeTypes.OneCode, "12345678901234567890");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Save($"{path}PostalOneCodeBarcode20Digits.png", BarCodeImageFormat.Png);
            //create OneCode with 25 digits
            gen = new BarcodeGenerator(EncodeTypes.OneCode, "1234567890123456789012345");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Save($"{path}PostalOneCodeBarcode25Digits.png", BarCodeImageFormat.Png);
            //create OneCode with 29 digits
            gen = new BarcodeGenerator(EncodeTypes.OneCode, "12345678901234567890123456789");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Save($"{path}PostalOneCodeBarcode29Digits.png", BarCodeImageFormat.Png);
            //create OneCode with 31 digits
            gen = new BarcodeGenerator(EncodeTypes.OneCode, "1234567890123456789012345678901");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Save($"{path}PostalOneCodeBarcode31Digits.png", BarCodeImageFormat.Png);
        }
    }
}