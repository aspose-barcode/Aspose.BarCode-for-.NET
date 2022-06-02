//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class ITF14QuietZone : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("ITF14QuietZone:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.ITF14, "12345678901231");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.ITF.ItfBorderType = ITF14BorderType.Frame;
            //ITF quiet zone 10 * XDimension
            gen.Parameters.Barcode.ITF.QuietZoneCoef = 10;
            gen.Save($"{path}ITF14QuietZone10.png", BarCodeImageFormat.Png);
            //ITF quiet zone 30 * XDimension
            gen.Parameters.Barcode.ITF.QuietZoneCoef = 30;
            gen.Save($"{path}ITF14QuietZone30.png", BarCodeImageFormat.Png);
        }
    }
}