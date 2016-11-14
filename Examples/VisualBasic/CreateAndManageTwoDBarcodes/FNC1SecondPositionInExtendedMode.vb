﻿Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Text
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class FNC1SecondPositionInExtendedMode
        Public Shared Sub Run()
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

            ' Set encoding mode
            builder.QREncodeMode = QREncodeMode.ExtendedCodetext

            ' Set error correction level
            builder.QRErrorLevel = QRErrorLevel.LevelL

            ' Set display text
            builder.Display2DText = "My Text"

            ' Get barcode image Bitmap
            Dim lBmp As Bitmap = builder.GenerateBarCodeImage()

            ' Save QR code
            lBmp.Save(dataDir & Convert.ToString("FNC1SecondPositionInExtendedMode_out.bmp"), ImageFormat.Bmp)
        End Sub
    End Class
End Namespace
