Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class RotateBarcodeImage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object and set CodeText, Barcode Symbology and RotationAngleF
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128) With { _
                .RotationAngleF = 180 _
            }
            BarCodeBuilder.Save(dataDir & Convert.ToString("barcode-image-rotate_out.jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg)
        End Sub
    End Class
End Namespace