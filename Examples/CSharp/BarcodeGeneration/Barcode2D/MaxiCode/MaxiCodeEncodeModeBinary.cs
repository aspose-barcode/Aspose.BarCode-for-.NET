//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MaxiCodeEncodeModeBinary : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MaxiCodeEncodeModeBinary:");

            byte[] encodedArr = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 };
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MaxiCode))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 15;
                //set MaxiCode encode mode to Binary
                gen.SetCodeText(encodedArr);
                gen.Parameters.Barcode.MaxiCode.MaxiCodeEncodeMode = MaxiCodeEncodeMode.Binary;
                gen.Save($"{path}MaxiCodeEncodeModeBinary.png", BarCodeImageFormat.Png);

            }
        }
    }
}