//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MaxiCodeEncodeMode2 : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeEncodeMode2:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MaxiCode, "");
            gen.Parameters.Barcode.XDimension.Pixels = 15;
            gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "MaxiCode Mode 2";

            string gs = "\u001d";
            string rs = "\u001e";
            string eot = "\u0004";
            //set MaxiCode encode mode to 2 and valid codetext
            gen.Parameters.Barcode.MaxiCode.MaxiCodeEncodeMode = 2;
            //[)>(rs)01(gs)(Postal Code)(gs)(Country Code)(gs)(Service Category)(gs)(Secondary Message)(eot)
            gen.CodeText = $"[)>{rs}01{gs}B1050{gs}056{gs}001{gs}ADDITIONAL DATA{eot}";
            gen.Save($"{path}MaxiCodeEncodeMode2First.png", BarCodeImageFormat.Png);
            
            //set MaxiCode encode mode to 2 and valid codetext
            gen.Parameters.Barcode.MaxiCode.MaxiCodeEncodeMode = 2;
            //(Postal Code 9 digits)(gs)(Country Code)(gs)(Service Category)(gs)(Secondary Message)(eot)
            gen.CodeText = $"123456789{gs}056{gs}001{gs}ADDITIONAL DATA{eot}";
            gen.Save($"{path}MaxiCodeEncodeMode2Second.png", BarCodeImageFormat.Png);
        }
	}
}