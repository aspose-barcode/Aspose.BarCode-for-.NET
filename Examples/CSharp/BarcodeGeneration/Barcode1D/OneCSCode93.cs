//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class OneCSCode93 : OneDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("OneCSCode93:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.Code93Extended, "CODE");
            //default value with checksum
            gen.Parameters.Barcode.IsChecksumEnabled = EnableChecksum.Yes;
            gen.Save($"{path}OneCSCode93WithChecksum.png", BarCodeImageFormat.Png);
            //no checksum value throws exception
            try
            {
                gen.Parameters.Barcode.IsChecksumEnabled = EnableChecksum.No;
                gen.GenerateBarCodeImage();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
	}
}