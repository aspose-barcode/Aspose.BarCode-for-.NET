Imports System.IO
Imports Aspose.BarCode
Imports System.Drawing.Printing

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class SaveBarcodeImagesToDifferentFormats
        Public Shared Sub Run()
            'ExStart:SaveBarcodeImagesToDifferentFormats
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode-image-format.jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg)
            'ExStart:SaveBarcodeImagesToDifferentFormats
        End Sub
    End Class
End Namespace
