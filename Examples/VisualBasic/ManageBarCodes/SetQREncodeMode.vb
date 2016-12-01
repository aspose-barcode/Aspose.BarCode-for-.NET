Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetQREncodeMode
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Create instance of BarCodeBuilder, specify codetext symbology and encode mode 
            Dim builder As New BarCodeBuilder("test123", EncodeTypes.QR) With { _
                .QREncodeMode = QREncodeMode.Auto _
            }
            builder.Save(dataDir & Convert.ToString("QR-Encode-mode_out.jpg"))
        End Sub
    End Class
End Namespace