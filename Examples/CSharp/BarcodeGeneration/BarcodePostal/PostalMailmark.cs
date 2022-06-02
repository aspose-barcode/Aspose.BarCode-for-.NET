//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class PostalMailmark : PostalBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("PostalMailmark:");

            BarcodeGenerator gen = null;
            //create Mailmark C Type
            gen = new BarcodeGenerator(EncodeTypes.Mailmark, "21B2254800659JW5O9QA6Y");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Save($"{path}PostalMailmarkCType.png", BarCodeImageFormat.Png);
            //create Mailmark L Type
            gen = new BarcodeGenerator(EncodeTypes.Mailmark, "41038422416563762EF61AH8T ");
            gen.Parameters.Barcode.XDimension.Pixels = 4;
            gen.Parameters.Barcode.BarHeight.Pixels = 50;
            gen.Save($"{path}PostalMailmarkLType.png", BarCodeImageFormat.Png);
        }
    }
}