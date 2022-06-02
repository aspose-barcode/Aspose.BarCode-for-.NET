//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MaxiCodeAspectRatio : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeAspectRatio:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MaxiCode, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.XDimension.Pixels = 15;
            //set aspect ratio 0.5
            gen.Parameters.Barcode.MaxiCode.AspectRatio = 0.5f;
            gen.Save($"{path}MaxiCodeAspectRatio0.5.png", BarCodeImageFormat.Png);
        }
    }
}