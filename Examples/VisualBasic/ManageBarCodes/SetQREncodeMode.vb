Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetQREncodeMode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            Dim builder As New BarCodeBuilder("test123", Symbology.QR)

            ' Set QR encode mode
            builder.QREncodeMode = QREncodeMode.Auto

            ' Save the file to disk  
            builder.Save(dataDir & Convert.ToString("QR-Encode-mode_out.jpg"))

        End Sub
    End Class
End Namespace