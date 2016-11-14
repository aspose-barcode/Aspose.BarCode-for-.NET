Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class ColorizeAnyPartoftheBarcodeImage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()
            Dim dst As String = dataDir & Convert.ToString("colorize-barcode_out.jpg")

            ' Instantiate barcode object and differnt properties
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128) With { _
                .BackColor = System.Drawing.Color.Yellow, _
                .ForeColor = System.Drawing.Color.Blue, _
                .BorderColor = System.Drawing.Color.Red, _
                .CodeTextColor = System.Drawing.Color.Red _
            }
            barCodeBuilder.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)
        End Sub
    End Class
End Namespace
