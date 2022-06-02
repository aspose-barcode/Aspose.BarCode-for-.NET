//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadQualityExamples
    {
		public static void Run()
        {
            //// =====================================================
            //// =====================================================
            ////  BarcodeRecognition: Options
            //// =====================================================
            //// =====================================================
            SaltAndPaperFiltering.Run();
            FastScan.Run();
            ComplexBackground.Run();
            DatamatrixIndustrialBarcodes.Run();
            DecreasedImage.Run();
            DetectScanGap.Run();
            RegularImage.Run();
            InvertImage.Run();
            MedianSmoothing.Run();
            IncorrectBarcodes.Run();
            MicroWhiteSpotsRemoving.Run();
            WhiteSpotsRemoving.Run();
            QRMicroQrRestoration.Run();
            OneDWipedBarsRestoration.Run();
            OneDDetectorSettings.Run();
            OneOldBarcodeDetector.Run();

            //// =====================================================
            //// =====================================================
            ////  BarcodeRecognition: Presets
            //// =====================================================
            //// =====================================================
            QualityPresetsMain.Run();
            QualityPresetsOneD.Run();
            MaxBarCodesPreset.Run();
        }
    }
}