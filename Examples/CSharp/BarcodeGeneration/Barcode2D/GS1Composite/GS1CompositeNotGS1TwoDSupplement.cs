//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GS1CompositeNotGS1TwoDSupplement : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GS1CompositeNotGS1TwoDSupplement:");

            //Encode GS1Composite barcode with not GS1 complaint 2D component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106(3202)012345|Aspose.Barcode"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;

                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_C;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;
                gen.Parameters.Barcode.GS1CompositeBar.IsAllowOnlyGS1Encoding = false;

                gen.Save($"{path}GS1Composite2D_NotGS1TwoDSupplement.png", BarCodeImageFormat.Png);
            }
        }
	}
}