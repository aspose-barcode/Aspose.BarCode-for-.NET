//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DotCodeReaderInitialization : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DotCodeReaderInitialization:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DotCode, "Aspose"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 10;
                //set flag that indicates that data is encoded for reader initialization
                gen.Parameters.Barcode.DotCode.IsReaderInitialization = true;
                gen.Save($"{path}DotCodeReaderInitialization.png", BarCodeImageFormat.Png);
            }
        }
    }
}