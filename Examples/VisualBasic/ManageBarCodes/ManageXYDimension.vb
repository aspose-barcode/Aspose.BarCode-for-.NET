Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class ManageXYDimension
        Public Shared Sub Run()
            'ExStart:ManageXYDimension
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()
            Dim dstCode128 As String = dataDir & Convert.ToString("code128-YDimensionChanged_out.jpg")

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128)

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dstCode128, System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Set the X-Dimension for the bars of the barcode
            barCodeBuilder.xDimension = 0.5F

            ' Set the measuring unit of barcode to millimeter
            barCodeBuilder.GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dstCode128, System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Instantiate barcode object and set differnt barcode properties
            Dim barCodeBuilder1 As New BarCodeBuilder("1234567", EncodeTypes.Pdf417) With { _
                .yDimension = 4 _
            }

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder1.Save(dataDir & Convert.ToString("pdf417-YDimensionChanged_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)
            'ExEnd:ManageXYDimension
        End Sub
    End Class
End Namespace