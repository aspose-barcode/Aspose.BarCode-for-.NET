Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class BarcodeCaption
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            'Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128

            barCodeBuilder.CaptionAbove.Visible = False

            ' Create caption object. Set its text and text alignment & also make it visible
            Dim caption As New Caption()
            caption.Text = "Aspose"
            caption.TextAlign = System.Drawing.StringAlignment.Center
            caption.Visible = True
            caption.Font = New System.Drawing.Font("Pristina", 14.0F)
            caption.ForeColor = System.Drawing.Color.Red

            ' Assign caption object to be displayed above the barcode
            barCodeBuilder.CaptionAbove = caption

            Dim captionBelow As New Caption()
            captionBelow.Text = "Aspose.BarCode Caption Below"
            captionBelow.TextAlign = System.Drawing.StringAlignment.Center
            captionBelow.Visible = True
            captionBelow.Font = New System.Drawing.Font("Pristina", 14.0F)
            captionBelow.ForeColor = System.Drawing.Color.OrangeRed

            ' Assign caption object to be displayed below the barcode
            barCodeBuilder.CaptionBelow = captionBelow

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode-caption_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

        End Sub
    End Class
End Namespace