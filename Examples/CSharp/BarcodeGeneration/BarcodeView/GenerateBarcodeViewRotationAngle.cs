//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeViewRotationAngle : GenerateBarcodeViewBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeViewRotationAngle:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code128, "ASPOSE");
            gen.Parameters.RotationAngle = 90;
            gen.Save($"{path}RotationAngle+90.png", BarCodeImageFormat.Png);
            gen.Parameters.RotationAngle = -90;
            gen.Save($"{path}RotationAngle-90.png", BarCodeImageFormat.Png);
            gen.Parameters.RotationAngle = 45;
            gen.Save($"{path}RotationAngle+45.png", BarCodeImageFormat.Png);
            gen.Parameters.RotationAngle = -45;
            gen.Save($"{path}RotationAngle-45.png", BarCodeImageFormat.Png);
            gen.Parameters.RotationAngle = 180;
            gen.Save($"{path}RotationAngle180.png", BarCodeImageFormat.Png);
        }
    }
}