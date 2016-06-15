Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.Programming.BarCode

    Public Class Create2DBarcodes
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
            Dim dst As String = dataDir & Convert.ToString("2d-barcode.jpg")

            Dim b As Aspose.BarCode.BarCodeBuilder
            b = New Aspose.BarCode.BarCodeBuilder()
            b.SymbologyType = Aspose.BarCode.Symbology.Pdf417
            ' width of each module
            b.xDimension = 0.6F
            ' height of each module
            b.yDimension = 1.2F
            b.CodeText = "this is some test code text. " & vbLf & " Second line " & vbLf & " third line."
            b.Save(dst, BarCodeImageFormat.Jpeg)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace