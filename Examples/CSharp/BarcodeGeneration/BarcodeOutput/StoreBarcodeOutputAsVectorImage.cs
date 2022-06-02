//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class StoreBarcodeOutputAsVectorImage : StoreBarcodeOutputBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("StoreBarcodeOutputAsVectorImage:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "12345678");
            //save as Emf
            gen.Save($"{path}VectorImageEmf.emf", BarCodeImageFormat.Emf);
            //save as Svg
            gen.Save($"{path}VectorImageSvg.svg", BarCodeImageFormat.Svg);
        }
    }
}