//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class StoreBarcodeOutputAsFile : StoreBarcodeOutputBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("StoreBarcodeOutputAsFile:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "12345678");
            gen.Save($"{path}StoreImageAsFile.png", BarCodeImageFormat.Png);
        }
    }
}