//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MaxiCodeMode2 : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeMode2:");

            string gs = "\u001d";
            string rs = "\u001e";
            string eot = "\u0004";
            //[)>(rs)01(gs)(Postal Code)(gs)(Country Code)(gs)(Service Category)(gs)(Secondary Message)(eot)
            string codetext = $"[)>{rs}01{gs}B1050{gs}056{gs}001{gs}ADDITIONAL DATA{eot}";

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MaxiCode, codetext))
            {
                //set MaxiCode mode to 2
                gen.Parameters.Barcode.MaxiCode.MaxiCodeMode = MaxiCodeMode.Mode2;

                gen.Parameters.Barcode.XDimension.Pixels = 15;
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "MaxiCode Mode 2";

                gen.Save($"{path}MaxiCodeMode2First.png", BarCodeImageFormat.Png);
            }


            //(Postal Code 9 digits)(gs)(Country Code)(gs)(Service Category)(gs)(Secondary Message)(eot)
            codetext = $"123456789{gs}056{gs}001{gs}ADDITIONAL DATA{eot}";
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MaxiCode, codetext))
            {
                //set MaxiCode mode to 2
                gen.Parameters.Barcode.MaxiCode.MaxiCodeMode = MaxiCodeMode.Mode2;

                gen.Parameters.Barcode.XDimension.Pixels = 15;
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "MaxiCode Mode 2";

                gen.Save($"{path}MaxiCodeMode2Second.png", BarCodeImageFormat.Png);
            }
        }
	}
}