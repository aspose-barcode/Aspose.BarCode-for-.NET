Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class GeneratingGS1ForCodablock
        Public Shared Sub Run()
            ' ExStart:GeneratingGS1ForCodablock
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Create instance of BarCodeBuilder class.
            Dim b As New BarCodeBuilder()

            ' Specify code text and set encode type.
            b.CodeText = "(01)03412345678900(17)010200"
            b.EncodeType = EncodeTypes.GS1CodablockF

            ' Save the image to disk in PNG format
            b.BarCodeImage.Save("GS1CodablockF_out.png")
            ' ExEnd:GeneratingGS1ForCodablock
        End Sub
    End Class
End Namespace
