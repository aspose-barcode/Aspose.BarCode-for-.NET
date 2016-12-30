Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class BarcodeCaption
        Public Shared Sub Run()
            'ExStart:BarcodeCaption
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
            'ExEnd:BarcodeCaption
        End Sub
    End Class
End Namespace