Imports System.IO
Imports Aspose.BarCode
Imports System.Drawing.Printing
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class SaveBarcodeImagesToDifferentFormats
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128)
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode-image-format_out.jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg)
        End Sub
    End Class
End Namespace