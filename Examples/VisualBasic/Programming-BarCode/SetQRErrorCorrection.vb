Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.Programming.BarCode

    Public Class SetQRErrorCorrection
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
            Dim dst As String = dataDir & Convert.ToString("QR-error-correction.jpg")

            ' Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            Dim builder As Aspose.BarCode.BarCodeBuilder
            builder = New Aspose.BarCode.BarCodeBuilder()
            builder.SymbologyType = Aspose.BarCode.Symbology.QR
            builder.QRErrorLevel = QRErrorLevel.LevelH
            builder.CodeText = "1234567890"
            builder.Save(dst, BarCodeImageFormat.Jpeg)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace