//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GS1CompositeStub : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GS1CompositeStub:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "ASPOSE.BARCODE"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 6;

                gen.Save($"{path}GS1CompositeStub.png", BarCodeImageFormat.Png);
            }
        }
	}
}