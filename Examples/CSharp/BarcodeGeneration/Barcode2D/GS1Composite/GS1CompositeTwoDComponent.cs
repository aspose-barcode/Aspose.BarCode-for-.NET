//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GS1CompositeTwoDComponent : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GS1CompositeTwoDComponent:");

            //Encode GS1Composite barcode with CC_A 2D component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106(3202)012345|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;

                gen.Save($"{path}GS1Composite2D_CC_A.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode with CC_B 2D component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106(3202)012345|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_B;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;

                gen.Save($"{path}GS1Composite2D_CC_B.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode with CC_C 2D component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106(3202)012345|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_C;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;

                gen.Save($"{path}GS1Composite2D_CC_C.png", BarCodeImageFormat.Png);
            }
        }
	}
}