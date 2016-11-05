Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class GenerateAustraliaPostBarcode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Set codetext
            Dim codeText As String = "12345678"

            ' Initialize BarCodeBuilder
            Dim builder As New BarCodeBuilder(codeText, Symbology.AustraliaPost)

            ' Set format control code to standard
            builder.CodeText = "1111111111"
            builder.Save(dataDir & Convert.ToString("AustraliaPost-Standard_out.png"))

            ' Set format control code to ReplyPaid
            builder.CodeText = "4545454545"
            builder.Save(dataDir & Convert.ToString("AustraliaPost-ReplyPaid_out.png"))

            ' Set format control code to Customer2
            builder.CodeText = "5959595959"
            builder.Save(dataDir & Convert.ToString("AustraliaPost-Customer2_out.png"))

            ' Set format control code to Customer3
            builder.CodeText = "6262626262"
            builder.Save(dataDir & Convert.ToString("AustraliaPost-Customer3_out.png"))

            ' Set format control code to Routing
            builder.CodeText = "8787878787"
            builder.Save(dataDir & Convert.ToString("AustraliaPost-Routing_out.png"))

            ' Set format control code to Redirection
            builder.CodeText = "9292929292"
            ' Save the image to disk in PNG format
            builder.Save(dataDir & Convert.ToString("AustraliaPost-Redirection_out.png"))
        End Sub
    End Class
End Namespace