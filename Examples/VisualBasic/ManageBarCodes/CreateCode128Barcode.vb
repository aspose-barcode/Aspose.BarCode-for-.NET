Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CreateCode128Barcode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Initialize BarCodeBuilder
            ' Instantiate barcode object and set CodeText & Barcode Symbology
            Dim barCodeBuilder As New BarCodeBuilder("1234", EncodeTypes.Code128)
            barCodeBuilder.Save(dataDir & Convert.ToString("Code128-customized_out.png"))
        End Sub
    End Class
End Namespace