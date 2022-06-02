//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class PatchCodeFormat : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("PatchCodeFormat:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.PatchCode, "Patch I");
            //set patch code without complimentary QR
            gen.Parameters.Barcode.PatchCode.PatchFormat = PatchFormat.A4;
            gen.Save($"{path}PatchCodeA4WithoutQR.png", BarCodeImageFormat.Png);
            //set patch code with complimentary QR
            gen.Parameters.Barcode.PatchCode.PatchFormat = PatchFormat.A4;
            gen.Parameters.Barcode.PatchCode.ExtraBarcodeText = "Aspose page extra info";
            gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
            gen.Save($"{path}PatchCodeA4WithQR.png", BarCodeImageFormat.Png);
        }
    }
}