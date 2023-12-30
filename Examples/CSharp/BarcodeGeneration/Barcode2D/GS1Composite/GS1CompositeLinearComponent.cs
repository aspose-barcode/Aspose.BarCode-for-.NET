//Copyright(c) 2001-2023 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GS1CompositeLinearComponent : TwoDBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("GS1CompositeLinearComponent:");

            //Encode GS1Composite barcode with EAN8 linear component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "20123451|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.EAN8;

                gen.Save($"{path}GS1Composite1D_EAN8.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode with UPCA linear component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "001234567895|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.UPCA;

                gen.Save($"{path}GS1Composite1D_UPCA.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode with EAN13 linear component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "2001234567893|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.EAN13;

                gen.Save($"{path}GS1Composite1D_EAN13.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode with UPCE linear component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "04252614|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.UPCE;

                gen.Save($"{path}GS1Composite1D_UPCE.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode with DatabarOmniDirectional linear component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)24012345678905|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.DatabarOmniDirectional;

                gen.Save($"{path}GS1Composite1D_DatabarOmniDirectional.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode with DatabarStackedOmniDirectional linear component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)24012345678905|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.DatabarStackedOmniDirectional;

                gen.Save($"{path}GS1Composite1D_DatabarStackedOmniDirectional.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode with DatabarStacked linear component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)24012345678905|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.DatabarStacked;

                gen.Save($"{path}GS1Composite1D_DatabarStacked.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode with DatabarLimited linear component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)15012345678907|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.DatabarLimited;

                gen.Save($"{path}GS1Composite1D_DatabarLimited.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode with DatabarExpanded linear component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106(3202)012345(15)991231|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.DatabarExpanded;

                gen.Save($"{path}GS1Composite1D_DatabarExpanded.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode with DatabarExpandedStacked linear component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106(3202)012345(15)991231|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.DatabarExpandedStacked;

                gen.Save($"{path}GS1Composite1D_DatabarExpandedStacked.png", BarCodeImageFormat.Png);
            }

            //Encode GS1Composite barcode with GS1Code128 linear component
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.GS1CompositeBar, "(01)98898765432106(3202)012345|(10)ABCD0123(240)0123456789"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 2;
                gen.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.None;
                gen.Parameters.Barcode.GS1CompositeBar.TwoDComponentType = TwoDComponentType.CC_A;
                gen.Parameters.Barcode.GS1CompositeBar.LinearComponentType = EncodeTypes.GS1Code128;

                gen.Save($"{path}GS1Composite1D_GS1Code128.png", BarCodeImageFormat.Png);
            }
        }
    }
}