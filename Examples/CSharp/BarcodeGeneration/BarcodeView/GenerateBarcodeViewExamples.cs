//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class GenerateBarcodeViewExamples
    {
		public static void Run()
        {
            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: Unit
            //// =====================================================
            //// =====================================================
            GenerateBarcodeViewUnit.Run();
            GenerateBarcodeViewResolution.Run();
            
            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: Appearance
            //// =====================================================
            //// =====================================================
            GenerateBarcodeViewAutoSizeModeInterpolation.Run();
            GenerateBarcodeViewAutoSizeModeNearest.Run();
            GenerateBarcodeViewAutoSizeModeNone.Run();
            GenerateBarcodeViewRotationAngle.Run();
            GenerateBarcodeViewBorder.Run();
            GenerateBarcodeViewPadding.Run();
            GenerateBarcodeViewBarWidthReduction.Run();

            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: Color
            //// =====================================================
            //// =====================================================
            BarcodeColorBorder.Run();
            BarcodeColorBackground.Run();
            BarcodeColorBarcode.Run();
            BarcodeColorCodetext.Run();
            BarcodeColorCaption.Run();

            //// =====================================================
            //// =====================================================
            ////  Barcode Generation: Text
            //// =====================================================
            //// =====================================================
            CodetextLocation.Run();
            CodetextAligment.Run();
            CodetextHide.Run();
            CodetextSpace.Run();
            CodetextFontModeAuto.Run();
            CodetextFontModeManual.Run();
            CodetextNoWrap.Run();
            CodetextTwoDDisplayText.Run();

            CaptionVisible.Run();
            CaptionAlignment.Run();
            CaptionPadding.Run();
            CaptionFont.Run();
            CaptionNoWrap.Run();
        }
    }
}