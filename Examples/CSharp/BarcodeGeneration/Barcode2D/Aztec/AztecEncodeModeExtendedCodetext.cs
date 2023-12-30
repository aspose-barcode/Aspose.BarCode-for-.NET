//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecEncodeModeExtendedCodetext : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecEncodeModeExtendedCodetext:");

            //create codetext
            AztecExtCodetextBuilder textBuilder = new AztecExtCodetextBuilder();
            textBuilder.AddECICodetext(ECIEncodings.Win1251, "Will");
            textBuilder.AddECICodetext(ECIEncodings.UTF8, "犬Right狗");
            textBuilder.AddECICodetext(ECIEncodings.UTF16BE, "犬Power狗");
            textBuilder.AddPlainCodetext("Plain text");

            //generate codetext
            string codetext = textBuilder.GetExtendedCodetext();

            //generate
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Aztec, codetext))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 15;
                //set encode mode to ExtendedCodetext
                gen.Parameters.Barcode.Aztec.AztecEncodeMode = AztecEncodeMode.ExtendedCodetext;
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "ExtendedCodetext mode";
                gen.Save($"{path}AztecEncodeModeExtendedCodetext.png", BarCodeImageFormat.Png);
            }
        }
    }
}