Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.Programming.BarCode

    Public Class CreateQRbarcode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
            Dim dst As String = dataDir & Convert.ToString("QR.jpg")

            Dim b As Aspose.BarCode.BarCodeBuilder
            b = New Aspose.BarCode.BarCodeBuilder()
            b.SymbologyType = Aspose.BarCode.Symbology.QR
            b.CodeText = "1234567890"
            b.Save(dst, BarCodeImageFormat.Bmp)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace