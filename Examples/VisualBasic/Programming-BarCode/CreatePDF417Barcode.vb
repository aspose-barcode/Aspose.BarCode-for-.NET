Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.Programming.BarCode

    Public Class CreatePDF417Barcode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
            Dim dst As String = dataDir & Convert.ToString("pdf417-barcode.jpg")

            Dim b As Aspose.BarCode.BarCodeBuilder
            b = New Aspose.BarCode.BarCodeBuilder()
            b.SymbologyType = Aspose.BarCode.Symbology.Pdf417
            b.CodeText = "1234567890"
            b.Save(dst, BarCodeImageFormat.Jpeg)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace