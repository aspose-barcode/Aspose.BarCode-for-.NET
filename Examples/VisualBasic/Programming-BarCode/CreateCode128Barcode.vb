Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.Programming.BarCode

    Public Class CreateCode128Barcode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
            Dim dst As String = dataDir & Convert.ToString("Code128-customized.png")

            ' Set codetext
            Dim codeText As String = "1234"

            ' Initialize BarCodeBuilder
            Dim builder As New BarCodeBuilder(codeText, Symbology.Code128)
            ' Code128 type handles Code A, B and C character sets automatically

            ' Save the image to disk in PNG format
            builder.Save(dst)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace