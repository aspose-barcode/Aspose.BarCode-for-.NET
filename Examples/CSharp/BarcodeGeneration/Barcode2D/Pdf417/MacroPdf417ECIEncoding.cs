//Copyright(c) 2001-2024 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class MacroPdf417ECIEncoding : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("MacroPdf417ECIEncoding:");
            Console.OutputEncoding = Encoding.Unicode;
            
            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.MacroPdf417, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            gen.Parameters.Barcode.Pdf417.Columns = 4;
            //set metadata
            gen.Parameters.Barcode.Pdf417.Pdf417MacroFileID = 12345678;
            gen.Parameters.Barcode.Pdf417.Pdf417MacroSegmentID = 12;
            gen.Parameters.Barcode.Pdf417.Pdf417MacroFileName = "伍01";
            gen.Parameters.Barcode.Pdf417.Pdf417MacroAddressee = "街";
            gen.Parameters.Barcode.Pdf417.Pdf417MacroSender = "компания";
            //set metadata ECI UTF8
            gen.Parameters.Barcode.Pdf417.Pdf417MacroECIEncoding = ECIEncodings.UTF8;
            gen.Save($"{path}MacroPdf417ECIEncoding.png", BarCodeImageFormat.Png);
            //try to recognize it
            BarCodeReader read = new BarCodeReader(gen.GenerateBarCodeImage(), DecodeType.MacroPdf417);
            foreach (BarCodeResult result in read.ReadBarCodes())
            {
                Console.WriteLine("---MacroPdf417ECIEncoding---");
                Console.WriteLine("Codetext:" + result.CodeText);
                Console.WriteLine("Pdf417MacroFileID:" + result.Extended.Pdf417.MacroPdf417FileID);
                Console.WriteLine("Pdf417MacroSegmentID:" + result.Extended.Pdf417.MacroPdf417SegmentID.ToString());
                Console.WriteLine("Pdf417MacroFileName:" + result.Extended.Pdf417.MacroPdf417FileName);
                Console.WriteLine("Pdf417MacroAddressee:" + result.Extended.Pdf417.MacroPdf417Addressee);
                Console.WriteLine("Pdf417MacroSender:" + result.Extended.Pdf417.MacroPdf417Sender);
            }
        }
	}
}