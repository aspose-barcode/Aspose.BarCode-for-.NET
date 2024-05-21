//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Pdf417EncodeModeBinary : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Pdf417EncodeModeBinary:");

            byte[] encodedArr = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 };

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Pdf417))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 10;
                //set Pdf417 encode mode to Binary
                gen.SetCodeText(encodedArr);
                gen.Parameters.Barcode.Pdf417.Pdf417EncodeMode = Pdf417EncodeMode.Binary;
                gen.Save($"{path}Pdf417EncodeModeBinary.png", BarCodeImageFormat.Png);
            }
        }
    }
}