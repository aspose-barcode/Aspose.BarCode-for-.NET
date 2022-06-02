//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Pdf417ReaderInitialization : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Pdf417ReaderInitialization:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417, "Aspose");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Pdf417.Columns = 3;
            //set flag that indicates that data is encoded for reader initialization
            gen.Parameters.Barcode.Pdf417.IsReaderInitialization = true;
            gen.Save($"{path}Pdf417ReaderInitialization.png", BarCodeImageFormat.Png);
        }
    }
}