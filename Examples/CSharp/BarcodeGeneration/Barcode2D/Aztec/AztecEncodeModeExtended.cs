//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class AztecEncodeModeExtended : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("AztecEncodeModeExtended:");

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
                //set encode mode to Extended
                gen.Parameters.Barcode.Aztec.AztecEncodeMode = AztecEncodeMode.Extended;
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "Extended mode";
                gen.Save($"{path}AztecEncodeModeExtended.png", BarCodeImageFormat.Png);
            }
        }
    }
}