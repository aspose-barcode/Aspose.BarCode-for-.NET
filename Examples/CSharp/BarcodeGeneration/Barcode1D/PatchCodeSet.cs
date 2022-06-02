//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class PatchCodeSet : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("PatchCodeSet:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.PatchCode, "Patch I");
            gen.Parameters.Barcode.CodeTextParameters.FontMode = FontMode.Manual;
            gen.Parameters.Barcode.CodeTextParameters.Font.Size.Pixels = 20;
            //Patch I
            gen.CodeText = "Patch I";
            gen.Save($"{path}PatchCodeI.png", BarCodeImageFormat.Png);
            //Patch II
            gen.CodeText = "Patch II";
            gen.Save($"{path}PatchCodeII.png", BarCodeImageFormat.Png);
            //Patch III
            gen.CodeText = "Patch III";
            gen.Save($"{path}PatchCodeIII.png", BarCodeImageFormat.Png);
            //Patch IV
            gen.CodeText = "Patch IV";
            gen.Save($"{path}PatchCodeIV.png", BarCodeImageFormat.Png);
            //Patch T
            gen.CodeText = "Patch T";
            gen.Save($"{path}PatchCodeT.png", BarCodeImageFormat.Png);
            //Patch VI
            gen.CodeText = "Patch VI";
            gen.Save($"{path}PatchCodeVI.png", BarCodeImageFormat.Png);
        }
    }
}