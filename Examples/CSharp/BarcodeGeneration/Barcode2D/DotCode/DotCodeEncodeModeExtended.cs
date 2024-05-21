//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DotCodeEncodeModeExtended : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DotCodeEncodeModeExtended:");

            //create codetext
            DotCodeExtCodetextBuilder textBuilder = new DotCodeExtCodetextBuilder();
            textBuilder.AddFNC1FormatIdentifier();
            textBuilder.AddECICodetext(ECIEncodings.UTF8, "犬Right狗");
            textBuilder.AddPlainCodetext("Plain text");
            textBuilder.AddFNC3SymbolSeparator();
            textBuilder.AddFNC3ReaderInitialization();
            textBuilder.AddPlainCodetext("Reader initialization info");
            
            //generate codetext
            string codetext = textBuilder.GetExtendedCodetext();
            
            //generate DotCode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DotCode, codetext))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 10;

                gen.Parameters.Barcode.DotCode.DotCodeEncodeMode = DotCodeEncodeMode.Extended;
                gen.Save($"{path}DotCodeEncodeModeExtended.png", BarCodeImageFormat.Png);
            }
        }
    }
}