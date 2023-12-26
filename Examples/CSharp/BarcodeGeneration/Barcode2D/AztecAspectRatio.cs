//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecAspectRatio : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecAspectRatio:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                //set aspect ratio 1
                gen.Parameters.Barcode.Aztec.AspectRatio = 1;
                gen.Save($"{path}AztecAspectRatio1.png", BarCodeImageFormat.Png);
                //set aspect ratio 0.5
                gen.Parameters.Barcode.Aztec.AspectRatio = 0.5f;
                gen.Save($"{path}AztecAspectRatio0.5.png", BarCodeImageFormat.Png);
            }
        }
    }
}