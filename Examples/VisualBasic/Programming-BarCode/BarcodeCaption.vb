Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.Programming.BarCode

    Public Class BarcodeCaption
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
            Dim dst As String = dataDir & Convert.ToString("barcode-caption.jpg")

            'Instantiate barcode object
            Dim bb As New BarCodeBuilder()

            'Set the Code text for the barcode
            bb.CodeText = "1234567"

            'Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128

            bb.CaptionAbove.Visible = False

            'Create caption object. Set its text and text alignment & also make it visible
            Dim caption As New Caption()
            caption.Text = "Aspose"
            caption.TextAlign = System.Drawing.StringAlignment.Center
            caption.Visible = True
            caption.Font = New System.Drawing.Font("Pristina", 14.0F)
            caption.ForeColor = System.Drawing.Color.Red

            'Assign caption object to be displayed above the barcode
            bb.CaptionAbove = caption

            Dim captionBelow As New Caption()
            captionBelow.Text = "Aspose.BarCode Caption Below"
            captionBelow.TextAlign = System.Drawing.StringAlignment.Center
            captionBelow.Visible = True
            captionBelow.Font = New System.Drawing.Font("Pristina", 14.0F)
            captionBelow.ForeColor = System.Drawing.Color.OrangeRed

            'Assign caption object to be displayed below the barcode
            bb.CaptionBelow = captionBelow

            'Save the image to your system and set its image format to Jpeg
            bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace