//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeTypeMicroQR : GenerateBarcodeTypeBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GenerateBarcodeTypeMicroQR:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "Aspose.Barcode");
            gen.Parameters.Barcode.QR.QrEncodeType = QREncodeType.ForceMicroQR;
            gen.Parameters.Barcode.XDimension.Pixels = 8;
            gen.Save($"{path}MicroQR.png", BarCodeImageFormat.Png);
        }
	}
}