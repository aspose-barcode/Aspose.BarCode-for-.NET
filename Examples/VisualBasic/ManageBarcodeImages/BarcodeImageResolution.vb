Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class BarcodeImageResolution
        Public Shared Sub Run()
            'ExStart:BarcodeImageResolution
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128

            ' Create an instance of resolution and apply on the barcode image with customized resolution settings
            barCodeBuilder.Resolution = New Resolution(200.0F, 400.0F, ResolutionMode.Customized)

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode-image-resolution_out.jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg)
            'ExEnd:BarcodeImageResolution
        End Sub
    End Class
End Namespace