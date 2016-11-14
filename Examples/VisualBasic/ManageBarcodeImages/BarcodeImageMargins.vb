Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class BarcodeImageMargins
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object and different properties
            Dim barCodeBuilder As New BarCodeBuilder("1234567890", EncodeTypes.Code128)
            barCodeBuilder.Margins.Left = 0.5F
            barCodeBuilder.Margins.Right = 0.5F
            barCodeBuilder.Margins.Top = 0.5F
            barCodeBuilder.Margins.Bottom = 0.5F
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode-image-margins_out.jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg)
        End Sub
    End Class
End Namespace