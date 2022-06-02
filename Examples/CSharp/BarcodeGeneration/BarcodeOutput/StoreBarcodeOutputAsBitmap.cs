//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System.Drawing;
using System.Drawing.Imaging;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class StoreBarcodeOutputAsBitmap : StoreBarcodeOutputBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("StoreBarcodeOutputAsBitmap:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "12345678");
            using (Bitmap bmp = gen.GenerateBarCodeImage())
                bmp.Save($"{path}StoreImageAsBitmap.png", ImageFormat.Png);
        }
    }
}