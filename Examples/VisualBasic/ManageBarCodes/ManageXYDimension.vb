Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class ManageXYDimension
        Public Shared Sub Run()
            'ExStart:ManageXYDimension
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()
            Dim dstCode128 As String = dataDir & Convert.ToString("code128-YDimensionChanged.jpg")

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dstCode128, System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Set the X-Dimension for the bars of the barcode
            barCodeBuilder.xDimension = 0.5F

            ' Set the measuring unit of barcode to millimeter
            barCodeBuilder.GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dstCode128, System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Instantiate barcode object
            Dim barCodeBuilder1 As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder1.CodeText = "1234567"

            ' Set the symbology type to Pdf417
            barCodeBuilder1.SymbologyType = Symbology.Pdf417

            ' Set the Y-Dimension for the bars of the barcode
            barCodeBuilder1.yDimension = 4

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder1.Save(dataDir & Convert.ToString("pdf417-YDimensionChanged_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)
            'ExEnd:ManageXYDimension            
        End Sub
    End Class
End Namespace