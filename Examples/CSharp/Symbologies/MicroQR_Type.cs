//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class MicroQR_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = Encoding.Unicode;
            //generate MicroQR Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "Aspose"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                //encode data as MicroQR
                gen.Parameters.Barcode.QR.QrEncodeType = QREncodeType.ForceMicroQR;
                //set error correction level 7%
                gen.Parameters.Barcode.QR.QrErrorLevel = QRErrorLevel.LevelL;
                //set version M4 can be Auto
                gen.Parameters.Barcode.QR.QrVersion = QRVersion.VersionM4;
                gen.Save($"{path}MicroQR.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("MicroQR_Type:");
            //recognize MicroQR Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}MicroQR.png", DecodeType.MicroQR))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}