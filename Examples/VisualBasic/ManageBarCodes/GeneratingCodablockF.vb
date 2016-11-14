Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class GeneratingCodablockF
        Public Shared Sub Run()
            ' ExStart:GeneratingCodablockF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Create instance of BarCodeBuilder class.
            Dim b As New BarCodeBuilder()

            ' Specify code text and set encode type.
            b.CodeText = "CODABLOCKF 01234567890123456789012digits"
            b.EncodeType = EncodeTypes.CodablockF

            ' Save the image to disk in PNG format
            b.BarCodeImage.Save("CodablockF_out.png")
            ' ExEnd:GeneratingCodablockF
        End Sub
    End Class
End Namespace