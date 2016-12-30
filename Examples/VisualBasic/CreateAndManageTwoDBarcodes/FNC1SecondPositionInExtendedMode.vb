Imports System.Drawing
Imports System.Drawing.Imaging
Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class FNC1SecondPositionInExtendedMode
        Public Shared Sub Run()
            'ExStart:FNC1SecondPositionInExtendedMode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' Create codetext
            Dim lTextBuilder As New QrExtCodetextBuilder()
            lTextBuilder.AddFNC1SecondPosition("12")
            lTextBuilder.AddPlainCodetext("TRUE3456")

            ' Generate codetext
            Dim lCodetext As String = lTextBuilder.GetExtendedCodetext()

            ' Instantiate barcode object and Set its CodeText and Symbology
            Dim builder As New BarCodeBuilder(lCodetext, EncodeTypes.QR)

            ' Set encoding mode, error correction level, display text
            builder.QREncodeMode = QREncodeMode.ExtendedCodetext
            builder.QRErrorLevel = QRErrorLevel.LevelL
            builder.Display2DText = "My Text"

            ' Get barcode image Bitmap and Save QR code
            Dim lBmp As Bitmap = builder.GenerateBarCodeImage()
            lBmp.Save(dataDir & Convert.ToString("FNC1SecondPositionInExtendedMode_out.bmp"), ImageFormat.Bmp)
            'ExEnd:FNC1SecondPositionInExtendedMode
        End Sub
    End Class
End Namespace
