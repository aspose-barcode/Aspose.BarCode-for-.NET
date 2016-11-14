Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class ManageXYDimension
        Public Shared Sub Run()
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
        End Sub
    End Class
End Namespace