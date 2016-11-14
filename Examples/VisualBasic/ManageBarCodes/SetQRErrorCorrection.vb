Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetQRErrorCorrection
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            Dim builder As New BarCodeBuilder("1234567890", EncodeTypes.QR)

            ' Set QRErrorLevel     
            builder.QRErrorLevel = QRErrorLevel.LevelH

            ' Save the file to disk
            builder.Save(dataDir & Convert.ToString("QR-error-correction_out.jpg"), BarCodeImageFormat.Jpeg)
        End Sub
    End Class
End Namespace