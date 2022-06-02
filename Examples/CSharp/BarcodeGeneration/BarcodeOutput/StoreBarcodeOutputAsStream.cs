//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System.IO;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class StoreBarcodeOutputAsStream : StoreBarcodeOutputBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("StoreBarcodeOutputAsStream:");
            using (Stream str = new FileStream($"{path}StoreImageAsStream.png", FileMode.Create, FileAccess.Write))
            {
                BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "12345678");
                gen.Save(str, BarCodeImageFormat.Png);
            }
        }
    }
}