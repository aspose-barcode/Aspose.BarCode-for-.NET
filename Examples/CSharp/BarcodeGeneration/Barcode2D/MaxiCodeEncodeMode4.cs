//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MaxiCodeEncodeMode4 : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeEncodeMode4:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MaxiCode, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.XDimension.Pixels = 15;
            //set MaxiCode encode mode to 4
            gen.Parameters.Barcode.MaxiCode.MaxiCodeEncodeMode = 4;
            gen.Save($"{path}MaxiCodeEncodeMode4.png", BarCodeImageFormat.Png);
        }
	}
}