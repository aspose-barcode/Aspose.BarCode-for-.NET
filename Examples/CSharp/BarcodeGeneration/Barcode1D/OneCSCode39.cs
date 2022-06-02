//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class OneCSCode39 : OneDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("OneCSCode39:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code39Extended, "CODE");
            //default value no checksum
            gen.Parameters.Barcode.IsChecksumEnabled = EnableChecksum.No;
            gen.Save($"{path}OneCSCode39WithoutChecksum.png", BarCodeImageFormat.Png);
            //value with checksum
            gen.Parameters.Barcode.IsChecksumEnabled = EnableChecksum.Yes;
            gen.Save($"{path}OneCSCode39WithChecksum.png", BarCodeImageFormat.Png);
        }
    }
}