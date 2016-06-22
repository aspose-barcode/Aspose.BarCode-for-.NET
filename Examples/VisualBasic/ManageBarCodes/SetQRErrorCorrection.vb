Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetQRErrorCorrection
        Public Shared Sub Run()

            'ExStart:SetQRErrorCorrection
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            Dim builder As New BarCodeBuilder()

            ' Set SymbologyType         
            builder.SymbologyType = Symbology.QR

            ' Set QRErrorLevel     
            builder.QRErrorLevel = QRErrorLevel.LevelH

            ' Set CodeText     
            builder.CodeText = "1234567890"

            ' Save the file to disk
            builder.Save(dataDir & Convert.ToString("QR-error-correction.jpg"), BarCodeImageFormat.Jpeg)
            'ExStart:SetQRErrorCorrection
        End Sub
    End Class
End Namespace