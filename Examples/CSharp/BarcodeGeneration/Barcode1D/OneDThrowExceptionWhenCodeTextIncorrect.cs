//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class OneDThrowExceptionWhenCodeTextIncorrect : OneDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("OneDThrowExceptionWhenCodeTextIncorrect:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.ITF6, "123457");
            gen.Parameters.Barcode.XDimension.Pixels = 2;
            //correct codetext with correction check
            gen.CodeText = "12345";
            gen.Parameters.Barcode.ThrowExceptionWhenCodeTextIncorrect = true;
            gen.Save($"{path}ITF6Correct.png", BarCodeImageFormat.Png);
            //incorrect codetext without correction check
            gen.CodeText = "12";
            gen.Parameters.Barcode.ThrowExceptionWhenCodeTextIncorrect = false;
            gen.Save($"{path}ITF6Filled.png", BarCodeImageFormat.Png);
            //incorrect codetext without correction check
            try
            {
                gen.CodeText = "12";
                gen.Parameters.Barcode.ThrowExceptionWhenCodeTextIncorrect = true;
                gen.GenerateBarCodeImage();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}