//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class StoreBarcodeOutputAsRasterImage : StoreBarcodeOutputBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("StoreBarcodeOutputAsRasterImage:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "12345678");
            //save as BMP
            gen.Save($"{path}RasterImageBmp.bmp", BarCodeImageFormat.Bmp);
            //save as Gif
            gen.Save($"{path}RasterImageGif.gif", BarCodeImageFormat.Gif);
            //save as Jpeg
            gen.Save($"{path}RasterImageJpeg.jpeg", BarCodeImageFormat.Jpeg);
            //save as Png
            gen.Save($"{path}RasterImagePng.png", BarCodeImageFormat.Png);
            //save as Tiff
            gen.Save($"{path}RasterImageTiff.tiff", BarCodeImageFormat.Tiff);
            //save as TiffInCmyk
            gen.Save($"{path}RasterImageTiffInCmyk.tiff", BarCodeImageFormat.TiffInCmyk);
        }
    }
}