Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class GenerateAustraliaPostBarcode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Set codetext
            Dim codeText As String = "1159628792"

            ' Initialize BarCodeBuilder
            Dim builder As New BarCodeBuilder(codeText, EncodeTypes.AustraliaPost)

            ' Set format control code to standard
            builder.Save(dataDir & Convert.ToString("AustraliaPost-Standard_out.png"))
        End Sub
    End Class
End Namespace