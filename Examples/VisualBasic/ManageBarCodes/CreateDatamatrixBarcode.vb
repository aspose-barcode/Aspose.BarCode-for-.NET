Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CreateDatamatrixBarcode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            Dim barCodeBuilder As New BarCodeBuilder("1234567890", EncodeTypes.DataMatrix)
            barCodeBuilder.Save(dataDir & Convert.ToString("datamatrix-barcode_out.jpg"), BarCodeImageFormat.Jpeg)
        End Sub
    End Class
End Namespace