//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GS1CompositeEncodationModes : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GS1CompositeEncodationModes:");

            //Encode GS1Composite barcode Encodation Method 0: Digits
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106|0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_B;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;
                gen.Parameters.Barcode.GS1CompositeBar.IsAllowOnlyGS1Encoding = false;

                gen.Save($"{path}GS1CompositeMode_0_Digits.png", BarCodeImageFormat.Png);
            }
            
            //Encode GS1Composite barcode Encodation Method 0: Capital Letters
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106|ABCDEFGHIJKLMNOPQRSTUVWXYZ"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_B;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;
                gen.Parameters.Barcode.GS1CompositeBar.IsAllowOnlyGS1Encoding = false;

                gen.Save($"{path}GS1CompositeMode_0_CapitalLetters.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode Encodation Method 0: Letters
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106|abcdefghijklmnopqrstuvwxyz"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_B;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;
                gen.Parameters.Barcode.GS1CompositeBar.IsAllowOnlyGS1Encoding = false;

                gen.Save($"{path}GS1CompositeMode_0_Letters.png", BarCodeImageFormat.Png);
            }
            
            //Encode GS1Composite barcode Encodation Method 0: Punctuation
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106|!\"%&'()*+,-./:;<=>?_ "))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_B;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;
                gen.Parameters.Barcode.GS1CompositeBar.IsAllowOnlyGS1Encoding = false;

                gen.Save($"{path}GS1CompositeMode_0_Punctuation.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode Encodation Method 10: AI 10(Batch or lot number)
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106|(10)0123"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;

                gen.Save($"{path}GS1CompositeMode_10_AI10.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode Encodation Method 10: AI 11(Production date (YYMMDD))
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106|(11)991231"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;

                gen.Save($"{path}GS1CompositeMode_10_AI11.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode Encodation Method 10: AI 17(Expiration date (YYMMDD))
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106|(17)991231"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;

                gen.Save($"{path}GS1CompositeMode_10_AI17.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode Encodation Method 10: AI 10(Batch or lot number) AI 11(Production date (YYMMDD))
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106|(11)991231(10)0123"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;

                gen.Save($"{path}GS1CompositeMode_10_AI11_AI10.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode Encodation Method 11: AI 90 (containing alphanumeric data)
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106|(90)9K12(10)0123"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;

                gen.Save($"{path}GS1CompositeMode_11.png", BarCodeImageFormat.Png);
            }
        }
	}
}