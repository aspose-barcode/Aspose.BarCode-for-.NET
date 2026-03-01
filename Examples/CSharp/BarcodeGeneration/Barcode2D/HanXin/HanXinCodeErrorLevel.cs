//Copyright(c) 2001-2026 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class HanXinCodeErrorLevel  : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("HanXinCodeErrorLevel:");
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.HanXin, "Han Xin code is two-dimensional (2D) matrix barcode symbology invented in 2007");
            //error level L1
            gen.Parameters.Barcode.HanXin.ErrorLevel = HanXinErrorLevel.L1;
            gen.Save($"{path}HanXinCodeErrorLevel_L1.png", BarCodeImageFormat.Png);
            //error level L4
            gen.Parameters.Barcode.HanXin.ErrorLevel = HanXinErrorLevel.L4;
            gen.Save($"{path}HanXinCodeErrorLevel_L4.png", BarCodeImageFormat.Png);
        }
    }
}