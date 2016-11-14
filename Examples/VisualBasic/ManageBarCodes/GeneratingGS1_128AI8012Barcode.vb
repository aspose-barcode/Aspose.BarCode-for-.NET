Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class GeneratingGS1_128AI8012Barcode
        Public Shared Sub Run()
            ' ExStart:GeneratingGS1_128AI8012Barcode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Create instance of BarCodeBuilder class.
            Dim b As New BarCodeBuilder()

            ' Specify code text and set encode type.
            b.CodeText = "(8012)ABC123"
            b.EncodeType = EncodeTypes.GS1Code128

            ' Save the image to disk in PNG format
            b.BarCodeImage.Save("AI8012_out.png")
            ' ExEnd:GeneratingGS1_128AI8012Barcode
        End Sub
    End Class
End Namespace
