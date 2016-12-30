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
    Class EncodeQRCodEInECIMode
        Public Shared Sub Run()
            'ExStart:FNC1FirstPositionInExtendedMode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' Initialize a BarCodeBuilder class object and Set its CodeText & Symbology Type 
            Dim builder As New BarCodeBuilder("12345TEXT", EncodeTypes.QR)

            ' Set encoding mode, ForceQR (default) for standard QR, ECI encoding type
            builder.QREncodeMode = QREncodeMode.ECIEncoding
            builder.QREncodeType = QREncodeType.ForceQR
            builder.ECIEncoding = ECIEncodings.UTF8

            ' Set error correction level
            builder.QRErrorLevel = QRErrorLevel.LevelL

            ' Get barcode image Bitmap and  Save QR code
            Dim lBmp As Bitmap = builder.GenerateBarCodeImage()
            lBmp.Save(dataDir & Convert.ToString("EncodeQRCodEInECIMode_out.bmp"), ImageFormat.Bmp)
            'ExEnd:FNC1FirstPositionInExtendedMode
        End Sub
    End Class
End Namespace