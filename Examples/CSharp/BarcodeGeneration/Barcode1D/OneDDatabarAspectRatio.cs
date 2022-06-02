//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class OneDDatabarAspectRatio : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("OneDDatabarAspectRatio:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DatabarStackedOmniDirectional, "(01)12345678901231");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set DataBar AspectRatio 15
            gen.Parameters.Barcode.DataBar.AspectRatio = 15;
            gen.Save($"{path}DatabarAspectRatio15.png", BarCodeImageFormat.Png);
            //set DataBar AspectRatio 30
            gen.Parameters.Barcode.DataBar.AspectRatio = 30;
            gen.Save($"{path}DatabarAspectRatio30.png", BarCodeImageFormat.Png);
        }
	}
}