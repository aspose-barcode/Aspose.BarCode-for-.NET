Imports System.IO
Imports Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
Imports Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
Imports Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
Imports Aspose.BarCode.Examples.VisualBasic.ManageBarCodes


Namespace Aspose.BarCode.Examples.VisualBasic
    Class RunExamples
        Public Shared Sub Main()
            Console.WriteLine("Open RunExamples.vb. " & vbLf & "In Main() method uncomment the example that you want to run.")
            Console.WriteLine("=====================================================")

            ' Uncomment the example that you want to run.

            ' =====================================================
            ' =====================================================
            '  ManageBarCode 
            ' =====================================================
            ' =====================================================

            'CreatePDF417Barcode.Run()
            'CreateQRbarcode.Run()
            'CreateDatamatrixBarcode.Run()
            'CodetextAppearance.Run()
            'BarcodeCaption.Run()
            'CreateCode128Barcode.Run()
            'SpecifySymbologies.Run()
            'SetCodeText.Run()
            'ManageCaption.Run()
            'SetHeightBarcodeBars.Run()
            'ManageXYDimension.Run()
            'ChecksumSupplementData.Run()
            'WideNarrowRatio.Run()
            'GenerateAustraliaPostBarcode.Run()
            'CodabarStartStopSymbols.Run()
            'SetHeightOfBarsInDataBarStackedOmniDirectional.Run()
            'ExportPropertiesToXML.Run()
            'DisplayChecksumCharacter.Run()
            'SetQREncodeMode.Run()
            'SetQRErrorCorrection.Run()
            'SetSupplementData.Run()
            'SpecifySymbology.Run()


            ' =====================================================
            ' =====================================================
            '  Manage BarCode Images
            ' =====================================================
            ' =====================================================

            'RotateBarcode.Run()
            'BarcodeImageBorders.Run()
            'ColorizeAnyPartoftheBarcodeImage.Run()
            'RotateBarcodeImage.Run()
            'BarcodeImageQuality.Run()
            'BarcodeImageMargins.Run()
            'ControlBarsFillingofOneDBarcodes.Run()
            'BarcodeImageResolution.Run()
            'SetSizeUnitForBarcodeImage.Run()
            'SaveBarcodeImagesToDifferentFormats.Run()
            'SaveBarcodeImageToStreams.Run()
            'PrintBarcodeImage.Run()
            'BarcodeCustomSize.Run()
            'SetITF14SpecifyBorderType.Run()
            'SetFrameOut.Run()
            'SetCodetextLocation.Run()
            'SetCodeAlignment.Run()
            'SetForeColorText.Run()
            'SetCodeTextFontFamilyNameAndSize.Run()
            'AddSpaceInBarCodeAndText.Run()
            'SetFontandColorSetting.Run()

            ' =====================================================
            ' =====================================================
            '  Create-And-Managing-2D-Barcodes
            ' =====================================================
            ' =====================================================

            'Create2DBarcodes.Run()
            'ManagePDF417Barcode.Run()
            'CreateSimpleDatamatrixBarCode.Run()
            'CreateEnCodeDatamatrixBarCode.Run()
            'CustomEncodingModeInDataMatrix.Run()
            'UseEncodeModeDatamatrixbarcode.Run()
            'DetectDotPeenDatamatrix.Run()
            'CreateAztecbarcode.Run()
            'UseAztecErrorCorrection.Run()
            'DetectUnicodeEncoding.Run()
            'EncodeQRCode.Run()
            'EncodeMicroQRCode.Run()
            'EncodeQRCodEInECIMode.Run()
            'FNC1FirstPositionInExtendedMode.Run()
            'FNC1SecondPositionInExtendedMode.Run()
            'MultiECIModeInExtendedMode.Run()
            'HideBarcodeCodeText.Run()
            'ReduceCodeTextFontSize.Run()
            'SetAspectRatio.Run()
            'CreateMultipleMacroPdf417.Run()


            ' =====================================================
            ' =====================================================
            '  ManageAndOptimizeBarcodeRecognition
            ' =====================================================
            ' =====================================================

            'ScanBarCodePicture.Run()
            'SupportImageFormat.Run()
            'RecognizeSpecificBarcodeSymbology.Run()
            'RecognizeMultipleSymbologies.Run()
            'DetectOrientationOfBarCode.Run()
            'DetectUnreadableBarcode.Run()
            'SetBarcodeOrientation.Run()
            'ImageProcessingBarcodeRecognition.Run()
            'MarkingBarCodeRegionsInImage.Run()
            'ReadBarcodeSpecificRegionOfImage.Run()
            'ReadMultipleMacropdf417BarcodeImages.Run()
            'ReadMultipleMacroPdf417Barcodes.Run()
            'GetBarCodeRegionInformationfromImage.Run()
            'GetAllPossible1DBarcodesfromImage.Run()
            'GetBarCodeRecognitionQualityInPercent.Run()
            'SwitchBarcodeRecognitionModes.Run()
            'OptimizingBarCodeRecognitionProcess.Run()
            'ManualHints.Run()
            'ReadMultipleBarcodeRegions.Run()
            'ECCTypeToEnCodeBarcode.Run()
            'DetectDecoratedDatamatrix.Run()


            ' Stop before exiting
            Console.WriteLine(Environment.NewLine + "Program Finished. Press any key to exit....")
            Console.ReadKey()
        End Sub

        Public Shared Function GetDataDir_ManageBarCodes() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("ManageBarCodes/"))
        End Function

        Public Shared Function GetDataDir_ManageBarCodesImages() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("ManageBarcodeImages/"))
        End Function

        Public Shared Function GetDataDir_CreateAndManage2DBarCodes() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("CreateAndManageTwoDBarcodes/"))
        End Function

        Public Shared Function GetDataDir_ManageAndOptimizeBarcodeRecognition() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("ManageAndOptimizeBarcodeRecognition/"))
        End Function


        Private Shared Function GetDataDir_Data() As String
            Dim parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent
            Dim startDirectory As String = Nothing
            If parent IsNot Nothing Then
                Dim directoryInfo = parent.Parent
                If directoryInfo IsNot Nothing Then
                    startDirectory = directoryInfo.FullName
                End If
            Else
                startDirectory = parent.FullName
            End If
            Return If(startDirectory IsNot Nothing, Path.Combine(startDirectory, "Data\"), Nothing)
        End Function
    End Class
End Namespace
