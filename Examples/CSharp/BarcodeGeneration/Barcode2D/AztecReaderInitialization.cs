//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecReaderInitialization : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecReaderInitialization:");

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, "Aspose"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 10;
                //set flag that indicates that data is encoded for reader initialization
                gen.Parameters.Barcode.Aztec.IsReaderInitialization = true;
                gen.Save($"{path}AztecReaderInitialization.png", BarCodeImageFormat.Png);
            }
        }
    }
}