//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MaxiCodeMode4 : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeMode4:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MaxiCode, "Aspose"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 15;
                //set MaxiCode mode to 4
                gen.Parameters.Barcode.MaxiCode.MaxiCodeMode = MaxiCodeMode.Mode4;
                gen.Save($"{path}MaxiCodeMode4.png", BarCodeImageFormat.Png);
            }
        }
	}
}