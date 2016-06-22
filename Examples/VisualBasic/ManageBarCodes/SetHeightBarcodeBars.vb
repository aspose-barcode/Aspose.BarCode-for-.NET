Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetHeightBarcodeBars
        Public Shared Sub Run()
            'ExStart:SetHeightBarcodeBars
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128

            ' Set the bar height to 3 millimeters
            barCodeBuilder.BarHeight = 3.0F

            ' Set the measuring unit of barcode to millimeter
            barCodeBuilder.GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter

            ' Save the image locally and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode3_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Set the bar height to 3 millimeters
            barCodeBuilder.BarHeight = 7.0F

            ' Save the image locally and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode7_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Set the bar height to 3 millimeters
            barCodeBuilder.BarHeight = 11.0F

            ' Save the image to disk
            barCodeBuilder.Save(dataDir & Convert.ToString("Code128-bar-height_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)
            'ExEnd:SetHeightBarcodeBars
        End Sub
    End Class
End Namespace