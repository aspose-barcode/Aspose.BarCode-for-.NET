Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

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