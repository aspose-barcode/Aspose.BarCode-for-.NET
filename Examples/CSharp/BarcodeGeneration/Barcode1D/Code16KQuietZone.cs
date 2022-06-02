//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class Code16KQuietZone : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("Code16KQuietZone:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code16K, "Aspose.Barcode");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //set Code 16K quiet zone 10
            gen.Parameters.Barcode.Code16K.QuietZoneLeftCoef = 10;
            gen.Parameters.Barcode.Code16K.QuietZoneRightCoef = 10;
            gen.Save($"{path}Code16KQuietZoneL10R10.png", BarCodeImageFormat.Png);
            //set Code 16K quiet zone 20
            gen.Parameters.Barcode.Code16K.QuietZoneLeftCoef = 20;
            gen.Parameters.Barcode.Code16K.QuietZoneRightCoef = 20;
            gen.Save($"{path}Code16KQuietZoneL20R20.png", BarCodeImageFormat.Png);
        }
    }
}