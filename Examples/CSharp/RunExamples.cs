using System;
using System.IO;
using Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes;
using Aspose.BarCode.Examples.CSharp.ManageAndOptimizeBarCodeRecognition;
using Aspose.BarCode.Examples.CSharp.ManageBarCodeImages;
using Aspose.BarCode.Examples.CSharp.ManageBarCodes;

namespace Aspose.BarCode.Examples.CSharp
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            // Uncomment the example that you want to run.

            //// =====================================================
            //// =====================================================
            ////  ManageBarCode 
            //// =====================================================
            //// =====================================================

            //CreatePDF417Barcode.Run();
            //CreateQRbarcode.Run();
            //CreateDatamatrixBarcode.Run();
            //CodetextAppearance.Run();
            //BarcodeCaption.Run();
            //CreateCode128Barcode.Run();
            //SpecifySymbologies.Run();
            //SetCodeText.Run();
            //ManageCaption.Run();
            //SetHeightBarcodeBars.Run();
            //ManageXYDimension.Run();
            //ChecksumSupplementData.Run();
            //WideNarrowRatio.Run();
            //GenerateAustraliaPostBarcode.Run();
            //CodabarStartStopSymbols.Run();
            //SetHeightOfBarsInDataBarStackedOmniDirectional.Run();
            //ExportPropertiesToXML.Run();
            //DisplayChecksumCharacter.Run();
            //SetQREncodeMode.Run();
            //SetQRErrorCorrection.Run();
            //SetSupplementData.Run();
            //SpecifySymbology.Run();


            //// =====================================================
            //// =====================================================
            ////  Manage BarCode Images
            //// =====================================================
            //// =====================================================

            //RotateBarcode.Run();
            //BarcodeImageBorders.Run();
            //ColorizeAnyPartoftheBarcodeImage.Run();
            //RotateBarcodeImage.Run();
            //BarcodeImageQuality.Run();
            //BarcodeImageMargins.Run();
            //ControlBarsFillingofOneDBarcodes.Run();
            //BarcodeImageResolution.Run();
            //SetSizeUnitForBarcodeImage.Run();
            //SaveBarcodeImagesToDifferentFormats.Run();
            //SaveBarcodeImageToStreams.Run();
            //PrintBarcodeImage.Run();
            //BarcodeCustomSize.Run();
            //SetITF14SpecifyBordeType.Run();
            //SpecifyITF14BorderThicknes.Run();
            //SetCodetextLocation.Run();
            //SetCodeAlignment.Run();
            //SetForeColorText.Run();
            //SetCodeTextFontFamilyNameAndSize.Run();
            //AddSpaceInBarCodeAndText.Run();
            //SetFontandColorSetting.Run();

            //// =====================================================
            //// =====================================================
            ////  Create-And-Managing-2D-Barcodes
            //// =====================================================
            //// =====================================================

            //Create2DBarcodes.Run();
            //ManagePDF417Barcode.Run();
            //CreateSimpleDatamatrixBarCode.Run();
            //CreateEnCodeDatamatrixBarCode.Run();
            //CustomEncodingModeInDataMatrix.Run();
            //UseEncodeModeDatamatrixbarcode.Run();
            //DetectDotPeenDatamatrix.Run();
            //CreateAztecbarcode.Run();
            //UseAztecErrorCorrection.Run();
            //DetectUnicodeEncoding.Run();
            //EncodeQRCode.Run();
            //EncodeMicroQRCode.Run();
            //EncodeQRCodEInECIMode.Run();
            //FNC1FirstPositionInExtendedMode.Run();
            //FNC1SecondPositionInExtendedMode.Run();
            //MultiECIModeInExtendedMode.Run();
            //HideBarcodeCodeText.Run();
            //ReduceCodeTextFontSize.Run();
            //SetAspectRatio.Run();
            //CreateMultipleMacroPdf417.Run();


            //// =====================================================
            //// =====================================================
            ////  ManageAndOptimizeBarcodeRecognition
            //// =====================================================
            //// =====================================================

            //ScanBarCodePicture.Run();
            //SupportImageFormat.Run();
            //RecognizeSpecificBarcodeSymbology.Run();
            //RecognizeMultipleSymbologies.Run();
            //DetectOrientationOfBarCode.Run();
            //DetectUnreadableBarcode.Run();
            //SetBarcodeOrientation.Run();
            //ImageProcessingBarcodeRecognition.Run();
            //MarkingBarCodeRegionsInImage.Run();
            //ReadBarcodeSpecificRegionOfImage.Run();
            //ReadMultipleMacropdf417BarcodeImages.Run();
            //ReadMultipleMacroPdf417Barcodes.Run();
            //GetBarCodeRegionInformationfromImage.Run();
            //GetAllPossible1DBarcodesfromImage.Run();
            //GetBarCodeRecognitionQualityInPercent.Run();
            //SwitchBarcodeRecognitionModes.Run();
            //OptimizingBarCodeRecognitionProcess.Run();
            //ManualHints.Run();
            //ReadMultipleBarcodeRegions.Run();
            //ECCTypeToEnCodeBarcode.Run();
            //DetectDecoratedDatamatrix.Run();
          

            // Stop before exiting
            Console.WriteLine(Environment.NewLine + "Program Finished. Press any key to exit....");
            Console.ReadKey();
        }


        public static String GetDataDir_ManageBarCodes()
        {
            return Path.GetFullPath(GetDataDir_Data() + "ManageBarCodes/");
        }

        public static String GetDataDir_ManageBarCodesImages()
        {
            return Path.GetFullPath(GetDataDir_Data() + "ManageBarcodeImages/");
        }

        public static String GetDataDir_CreateAndManage2DBarCodes()
        {
            return Path.GetFullPath(GetDataDir_Data() + "CreateAndManageTwoDBarcodes/");
        }

        public static String GetDataDir_ManageAndOptimizeBarcodeRecognition()
        {
            return Path.GetFullPath(GetDataDir_Data() + "ManageAndOptimizeBarcodeRecognition/");
        }

        




        private static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return startDirectory != null ? Path.Combine(startDirectory, "Data\\") : null;
        }
    }
}
