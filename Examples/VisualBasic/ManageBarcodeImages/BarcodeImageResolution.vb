Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class BarcodeImageResolution
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            ' Create an instance of resolution and apply on the barcode image with customized resolution settings
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128) With { _
                .Resolution = New Resolution(200.0F, 400.0F, ResolutionMode.Customized) _
            }

            ' Save the image to your system and set its image format to Jpeg
            BarCodeBuilder.Save(dataDir & Convert.ToString("barcode-image-resolution_out.jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg)
        End Sub
    End Class
End Namespace