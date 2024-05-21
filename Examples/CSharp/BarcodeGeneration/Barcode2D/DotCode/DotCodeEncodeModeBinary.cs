//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DotCodeEncodeModeBinary : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DotCodeEncodeModeBinary:");

            byte[] encodedArr = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 };

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DotCode))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 10;
                //set DotCode encode mode to Binary
                gen.SetCodeText(encodedArr);
                gen.Parameters.Barcode.DotCode.DotCodeEncodeMode = DotCodeEncodeMode.Binary;
                gen.Save($"{path}DotCodeEncodeModeBinary.png", BarCodeImageFormat.Png);

            }
        }
    }
}