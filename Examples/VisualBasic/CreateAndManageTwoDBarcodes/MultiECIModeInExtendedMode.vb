Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Text
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
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

            ' Initialize a BarCodeBuilder class object

            Dim builder As New BarCodeBuilder()
            ' Set its Symbology
            builder.SymbologyType = Symbology.QR

            ' set encoding mode
            builder.QREncodeMode = QREncodeMode.ExtendedCodetext

            ' Set error correction level
            builder.QRErrorLevel = QRErrorLevel.LevelL

            ' Set code text
            builder.CodeText = lCodetext

            ' Set display text
            builder.Display2DText = "My Text"

            ' Get barcode image Bitmap
            Dim lBmp As Bitmap = builder.GenerateBarCodeImage()

            ' Save QR code
            lBmp.Save(dataDir & Convert.ToString("MultiECIModeInExtendedMode_out.bmp"), ImageFormat.Bmp)
            'ExEnd:MultiECIModeInExtendedMode
        End Sub
    End Class
End Namespace