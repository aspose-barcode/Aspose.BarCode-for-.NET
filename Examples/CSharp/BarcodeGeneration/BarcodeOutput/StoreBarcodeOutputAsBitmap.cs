//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using Aspose.BarCode.Generation;
#if NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_1_OR_GREATER
using Aspose.Drawing;
using Aspose.Drawing.Imaging;
#else
using System.Drawing;
using System.Drawing.Imaging;
#endif

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