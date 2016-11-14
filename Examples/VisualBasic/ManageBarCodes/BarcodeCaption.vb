Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class BarcodeCaption
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128)
            barCodeBuilder.CaptionAbove.Visible = False

            ' Create caption object. Set its text and text alignment & also make it visible
            Dim caption As New Caption() With { _
                 .Text = "Aspose", _
                .TextAlign = System.Drawing.StringAlignment.Center, _
                .Visible = True, _
                .Font = New System.Drawing.Font("Pristina", 14.0F), _
                .ForeColor = System.Drawing.Color.Red _
            }

            ' Assign caption object to be displayed above the barcode
            barCodeBuilder.CaptionAbove = caption

            Dim captionBelow As New Caption() With { _
                 .Text = "Aspose.BarCode Caption Below", _
                 .TextAlign = System.Drawing.StringAlignment.Center, _
                 .Visible = True, _
                 .Font = New System.Drawing.Font("Pristina", 14.0F), _
                 .ForeColor = System.Drawing.Color.OrangeRed _
            }

            ' Assign caption object to be displayed below the barcode
            barCodeBuilder.CaptionBelow = captionBelow

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode-caption_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

        End Sub
    End Class
End Namespace