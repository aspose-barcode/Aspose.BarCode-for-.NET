Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class BarcodeImageQuality
        Public Shared Sub Run()
            'ExStart:BarcodeImageQuality
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128

            ' Set the image quality mode to anti alias
            barCodeBuilder.ImageQuality = ImageQualityMode.AntiAlias

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode-image-quality_out.jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg)
            'ExEnd:BarcodeImageQuality
        End Sub
    End Class
End Namespace