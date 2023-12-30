//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DotCodeAspectRatio : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DotCodeAspectRatio:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DotCode, "Aspose"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 10;
                //set aspect ratio 0.5
                gen.Parameters.Barcode.DotCode.AspectRatio = 0.5f;
                gen.Save($"{path}DotCodeAspectRatio0.5.png", BarCodeImageFormat.Png);
            }
        }
    }
}