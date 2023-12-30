//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MaxiCodeEncodeModeExtendedCodetext : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeEncodeModeBytes:");

            //create codetext
            MaxiCodeExtCodetextBuilder textBuilder = new MaxiCodeExtCodetextBuilder();
            textBuilder.AddECICodetext(ECIEncodings.Win1251, "Will");
            textBuilder.AddECICodetext(ECIEncodings.UTF8, "犬Right狗");
            textBuilder.AddECICodetext(ECIEncodings.UTF16BE, "犬Power狗");
            textBuilder.AddPlainCodetext("Plain text");

            //generate codetext
            string codetext = textBuilder.GetExtendedCodetext();

            //generate
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MaxiCode, codetext))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 15;
                //set encode mode to ExtendedCodetext
                gen.Parameters.Barcode.MaxiCode.MaxiCodeEncodeMode = MaxiCodeEncodeMode.ExtendedCodetext;
                gen.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = "ExtendedCodetext mode";
                gen.Save($"{path}MaxiCodeEncodeModeExtendedCodetext.png", BarCodeImageFormat.Png);
            }
        }
    }
}