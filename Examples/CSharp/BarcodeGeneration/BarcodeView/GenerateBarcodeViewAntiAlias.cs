//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeViewAntiAlias : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeViewAntiAlias:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "ASPOSE Barcode");
            gen.Parameters.RotationAngle = 45;
            //AntiAlias is enabled
            gen.Parameters.UseAntiAlias = true;
            gen.Save($"{path}AntiAlias_Enabled.png", BarCodeImageFormat.Png);
            //AntiAlias is disabled
            gen.Parameters.UseAntiAlias = false;
            gen.Save($"{path}AntiAlias_Disabled.png", BarCodeImageFormat.Png);
        }
    }
}