Imports System.IO
Imports Aspose.BarCode.Examples.VisualBasic.BarCode.Image.Basic.Features
Imports Aspose.BarCode.Examples.VisualBasic.BarCode.Image.Utility.Features
Imports Aspose.BarCode.Examples.VisualBasic.BarCode.Recognition
Imports Aspose.BarCode.Examples.VisualBasic.Programming.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic
    Module RunExamples

        Sub Main()
            Console.WriteLine("Open RunExamples.vb." & vbLf & "In Main() method uncomment the example that you want to run.")
            Console.WriteLine("=====================================================")

            ' Uncomment the example that you want to run.

            '' =====================================================
            '' =====================================================
            '' Programming BarCode
            '' =====================================================
            '' =====================================================

            CreateCode128Barcode.Run()
            'GenerateAustraliaPostBarcode.Run()
            'ManageXYDimension.Run()
            'SetHeightBarcodeBars.Run()
            'CodabarStartStopSymbols.Run()
            'ChecksumSupplementData.Run()
            'WideNarrowRatio.Run()
            'CodetextAppearance.Run()
            'BarcodeCaption.Run()
            'SetCodeText.Run()
            'SpecifySymbology.Run()
            'SetQREncodeMode.Run()
            'SetQRErrorCorrection.Run()
            'CreateQRbarcode.Run()
            'RotateBarcode.Run()
            'CreateDatamatrixBarcode.Run()
            'CreatePDF417Barcode.Run()
            'Create2DBarcodes.Run()

            '' =====================================================
            '' =====================================================
            '' BarCode Image
            '' =====================================================
            '' =====================================================

            '' Basic Features
            '' =====================================================

            'ColorizeAnyPartoftheBarcodeImage.Run()
            'BarcodeImageQuality.Run()
            'RotateBarcodeImage.Run()
            'BarcodeImageMargins.Run()
            'BarcodeImageBorders.Run()

            '' Utility Features
            '' =====================================================

            'BarcodeImageResolution.Run()
            'BarcodeCustomSize.Run()
            'PrintBarcodeImage.Run()
            'SaveBarcodeImagesToDifferentFormats.Run()
            'SetSizeUnitForBarcodeImage.Run()

            '' =====================================================
            '' =====================================================
            '' BarCode Recognition
            '' =====================================================
            '' =====================================================

            'DetectOrientationOfBarCode.Run()

            ' Stop before exiting
            Console.WriteLine(Environment.NewLine + "Program Finished. Press any key to exit....")
            Console.ReadKey()

        End Sub

        Friend Function GetDataDir_ProgrammingBarCode() As String
            Return Path.GetFullPath("../../Programming-BarCode/Data/")
        End Function

        Friend Function GetDataDir_BarCodeImage() As String
            Return Path.GetFullPath("../../BarCode-Image/Data/")
        End Function

        Friend Function GetDataDir_BarCodeRecognition() As String
            Return Path.GetFullPath("../../BarCode-Recognition/Data/")
        End Function

    End Module
End Namespace