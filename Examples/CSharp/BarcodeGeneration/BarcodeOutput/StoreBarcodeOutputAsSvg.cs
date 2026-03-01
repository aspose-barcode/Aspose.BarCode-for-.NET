//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;
#if NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_1_OR_GREATER
using Aspose.Drawing;
#else
using System.Drawing;
#endif

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class StoreBarcodeOutputAsSvg : StoreBarcodeOutputBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("StoreBarcodeOutputAsSvg:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "12345678");
            //save as Svg normal
            gen.Save($"{path}VectorImageSvg_Normal.svg", BarCodeImageFormat.Svg);
            //save as Svg non-dimensional
            gen = new BarcodeGenerator(EncodeTypes.Code128, "12345678");
            gen.Parameters.Image.Svg.IsExplicitSizeInPixels = false;
            gen.Save($"{path}VectorImageSvg_NonDimensional.svg", BarCodeImageFormat.Svg);
            //save as Svg with path 
            gen = new BarcodeGenerator(EncodeTypes.Code128, "12345678");
            gen.Parameters.Image.Svg.IsTextDrawnInTextElement = false;
            gen.Save($"{path}VectorImageSvg_AsPath.svg", BarCodeImageFormat.Svg);

            //color modes
            gen = new BarcodeGenerator(EncodeTypes.Code128, "12345678");
            gen.Parameters.Barcode.BarColor = Color.FromArgb(255, 20, 150);
            //save as Svg with rgb color
            gen.Parameters.Image.Svg.SvgColorMode = SvgColorMode.RGB;
            gen.Save($"{path}VectorImageSvg_ColorRGB.svg", BarCodeImageFormat.Svg);
            //save as Svg with rgb color
            gen.Parameters.Image.Svg.SvgColorMode = SvgColorMode.RGBA;
            gen.Save($"{path}VectorImageSvg_ColorRGBA.svg", BarCodeImageFormat.Svg);
            //save as Svg with rgb color
            gen.Parameters.Image.Svg.SvgColorMode = SvgColorMode.HSL;
            gen.Save($"{path}VectorImageSvg_ColorHSL.svg", BarCodeImageFormat.Svg);
            //save as Svg with rgb color
            gen.Parameters.Image.Svg.SvgColorMode = SvgColorMode.HSLA;
            gen.Save($"{path}VectorImageSvg_ColorHSLA.svg", BarCodeImageFormat.Svg);
        }
    }
}