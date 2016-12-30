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
    Class MultiECIModeInExtendedMode
        Public Shared Sub Run()
            'ExStart:MultiECIModeInExtendedMode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' Create codetext
            Dim lTextBuilder As New QrExtCodetextBuilder()
            lTextBuilder.AddECICodetext(ECIEncodings.Win1251, "Will")
            lTextBuilder.AddECICodetext(ECIEncodings.UTF8, "Right")
            lTextBuilder.AddECICodetext(ECIEncodings.UTF16BE, "Power")
            lTextBuilder.AddPlainCodetext("t\e\\st")

            ' Generate codetext
            Dim lCodetext As String = lTextBuilder.GetExtendedCodetext()

            ' Initialize a BarCodeBuilder class object, Set CodeText, Symbology, Encoding mode, correction level and display text
            Dim builder As New BarCodeBuilder(lCodetext, EncodeTypes.QR)
            builder.QREncodeMode = QREncodeMode.ExtendedCodetext
            builder.QRErrorLevel = QRErrorLevel.LevelL
            builder.CodeText = lCodetext
            builder.Display2DText = "My Text"
            Dim lBmp As Bitmap = builder.GenerateBarCodeImage()
            lBmp.Save(dataDir & Convert.ToString("MultiECIModeInExtendedMode_out.bmp"), ImageFormat.Bmp)
            'ExEnd:MultiECIModeInExtendedMode
        End Sub
    End Class
End Namespace