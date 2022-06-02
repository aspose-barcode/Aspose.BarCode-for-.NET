//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class PostalExceptionIncorrectCodeText : PostalBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("PostalExceptionIncorrectCodeText:");

            BarcodeGenerator gen = null;
            gen = new BarcodeGenerator(EncodeTypes.Planet, "1234567WRONG");
            gen.Parameters.Barcode.ThrowExceptionWhenCodeTextIncorrect = true;
            try
            {
                gen.GenerateBarCodeImage();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            gen = new BarcodeGenerator(EncodeTypes.Postnet, "1234567WRONG");
            gen.Parameters.Barcode.ThrowExceptionWhenCodeTextIncorrect = true;
            try
            {
                gen.GenerateBarCodeImage();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}