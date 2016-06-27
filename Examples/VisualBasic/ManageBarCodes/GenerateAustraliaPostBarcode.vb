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
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Standard
            ' Save the image to disk in PNG format
            builder.Save(dataDir & Convert.ToString("AustraliaPost-Standard_out.png"))

            ' Set format control code to ReplyPaid
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.ReplyPaid
            ' Save the image to disk in PNG format
            builder.Save(dataDir & Convert.ToString("AustraliaPost-ReplyPaid_out.png"))

            ' Set format control code to Customer2
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Customer2
            ' Save the image to disk in PNG format
            builder.Save(dataDir & Convert.ToString("AustraliaPost-Customer2_out.png"))

            ' Set format control code to Customer3
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Customer3
            ' Save the image to disk in PNG format
            builder.Save(dataDir & Convert.ToString("AustraliaPost-Customer3_out.png"))

            ' Set format control code to Routing
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Routing
            ' Save the image to disk in PNG format
            builder.Save(dataDir & Convert.ToString("AustraliaPost-Routing_out.png"))

            ' Set format control code to Redirection
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Redirection
            ' Save the image to disk in PNG format
            builder.Save(dataDir & Convert.ToString("AustraliaPost-Redirection_out.png"))
            Console.WriteLine(Convert.ToString(Environment.NewLine + "AustraliaPost Barcodes saved at ") & dataDir)
        End Sub
    End Class
End Namespace