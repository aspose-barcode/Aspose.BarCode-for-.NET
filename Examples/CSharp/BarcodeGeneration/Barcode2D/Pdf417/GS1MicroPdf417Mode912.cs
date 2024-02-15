//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GS1MicroPdf417Mode912 : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GS1MicroPdf417Mode912:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1MicroPdf417, "(17)991231(10)ABCD");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Pdf417.Columns = 2;
            gen.Parameters.Barcode.Pdf417.IsLinked = true;
            //Micro Pdf417 Codewords 912 - "Linked" UCC/EAN-128, GS1 AI 17 and 10
            gen.Save($"{path}GS1MicroPdf417Mode912_17_10.png", BarCodeImageFormat.Png);
            //Micro Pdf417 Codewords 912 - "Linked" UCC/EAN-128, GS1 AI 15 and 10
            gen.CodeText = "(15)991231(10)ABCD";
            gen.Save($"{path}GS1MicroPdf417Mode912_15_10.png", BarCodeImageFormat.Png);
            //Micro Pdf417 Codewords 912 - "Linked" UCC/EAN-128, GS1 AI 13 and 21
            gen.CodeText = "(13)991231(21)ABCD";
            gen.Save($"{path}GS1MicroPdf417Mode912_13_21.png", BarCodeImageFormat.Png);
            //Micro Pdf417 Codewords 912 - "Linked" UCC/EAN-128, GS1 AI 11 and 21
            gen.CodeText = "(11)991231(21)ABCD";
            gen.Save($"{path}GS1MicroPdf417Mode912_11_21.png", BarCodeImageFormat.Png);
            //Micro Pdf417 Codewords 912 - "Linked" UCC/EAN-128, GS1 AI 17 without second GS1 AI
            gen.CodeText = "(17)991231";
            gen.Save($"{path}GS1MicroPdf417Mode912_17.png", BarCodeImageFormat.Png);
        }
    }
}