Imports System.IO
Imports System.Drawing.Printing
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class SetSizeUnitForBarcodeImage
        Public Shared Sub Run()
            'ExStart:SetSizeUnitForBarcodeImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128

            ' Set the bar height to 3 points
            barCodeBuilder.BarHeight = 3.0F

            ' Set the measuring unit of barcode to point
            barCodeBuilder.GraphicsUnit = System.Drawing.GraphicsUnit.Point

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode-size-unit_out.jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg)
            'ExEnd:SetSizeUnitForBarcodeImage

        End Sub
    End Class
End Namespace
