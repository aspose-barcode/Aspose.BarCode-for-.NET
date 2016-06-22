Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CreateCode128Barcode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Set codetext
            Dim codeText As String = "1234"

            ' Initialize BarCodeBuilder
            Dim builder As New BarCodeBuilder(codeText, Symbology.Code128)

            ' Code128 type handles Code A, B and C character sets automatically

            ' Save the image to disk in PNG format
            builder.Save(dataDir & Convert.ToString("Code128-customized_out.png"))

        End Sub
    End Class
End Namespace