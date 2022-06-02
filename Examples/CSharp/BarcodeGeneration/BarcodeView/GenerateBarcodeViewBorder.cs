//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeViewBorder : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeViewBorder:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "ASPOSE");
            //set border visible
            gen.Parameters.Border.Visible = true;
            //set border size to 5 pizels
            gen.Parameters.Border.Width.Pixels = 5;
            gen.Parameters.Border.DashStyle = BorderDashStyle.Solid;
            gen.Save($"{path}BorderSolid.png", BarCodeImageFormat.Png);
            gen.Parameters.Border.DashStyle = BorderDashStyle.Dash;
            gen.Save($"{path}BorderDash.png", BarCodeImageFormat.Png);
            gen.Parameters.Border.DashStyle = BorderDashStyle.Dot;
            gen.Save($"{path}BorderDot.png", BarCodeImageFormat.Png);
            gen.Parameters.Border.DashStyle = BorderDashStyle.DashDot;
            gen.Save($"{path}BorderDashDot.png", BarCodeImageFormat.Png);
            gen.Parameters.Border.DashStyle = BorderDashStyle.DashDotDot;
            gen.Save($"{path}BorderDashDotDot.png", BarCodeImageFormat.Png);
        }
    }
}