//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class HanXinCodeVersion : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("HanXinCodeVersion:");
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.HanXin, "Han Xin code is two-dimensional (2D) matrix barcode symbology invented in 2007");
            //version 10
            gen.Parameters.Barcode.HanXin.Version = HanXinVersion.Version10;
            gen.Save($"{path}HanXinCodeVersion10.png", BarCodeImageFormat.Png);
        }
    }
}