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
    Class EncodeQRCode
        Public Shared Sub Run()
            'ExStart:EncodeQRCode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' Initialize a BarCodeBuilder class object and Set CodeText & Symbology Type
            Dim builder As New BarCodeBuilder("12345TEXT", EncodeTypes.QR)

            ' Set ForceQR (default) for standard QR, code text and  
            builder.QREncodeMode = QREncodeMode.Auto
            builder.QREncodeType = QREncodeType.ForceQR
            builder.QRErrorLevel = QRErrorLevel.LevelL

            ' Get barcode image Bitmap and Save QR code
            Dim lBmp As Bitmap = builder.GenerateBarCodeImage()            ' 
            lBmp.Save(dataDir & Convert.ToString("EncodeQA_out.bmp"), ImageFormat.Bmp)
            'ExEnd:EncodeQRCode
        End Sub
    End Class
End Namespace