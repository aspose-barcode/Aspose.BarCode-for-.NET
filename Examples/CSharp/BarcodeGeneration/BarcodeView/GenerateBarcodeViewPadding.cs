//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeViewPadding : GenerateBarcodeViewBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeViewPadding:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "ASPOSE");
            //set border
            gen.Parameters.Border.Visible = true;
            gen.Parameters.Border.Width.Pixels = 5;
            gen.Parameters.Border.DashStyle = BorderDashStyle.Solid;
            //set padding to 10 pixels
            gen.Parameters.Barcode.Padding.Left.Pixels = 10;
            gen.Parameters.Barcode.Padding.Top.Pixels = 10;
            gen.Parameters.Barcode.Padding.Right.Pixels = 10;
            gen.Parameters.Barcode.Padding.Bottom.Pixels = 10;
            gen.Save($"{path}Padding10Pixels.png", BarCodeImageFormat.Png);
            //set padding to 10 Millimeters
            gen.Parameters.Barcode.Padding.Left.Millimeters = 10;
            gen.Parameters.Barcode.Padding.Top.Millimeters = 10;
            gen.Parameters.Barcode.Padding.Right.Millimeters = 10;
            gen.Parameters.Barcode.Padding.Bottom.Millimeters = 10;
            gen.Save($"{path}Padding10Millimeters.png", BarCodeImageFormat.Png);
        }
    }
}