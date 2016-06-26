Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class ColorizeAnyPartoftheBarcodeImage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()
            Dim dst As String = dataDir & Convert.ToString("colorize-barcode_out.jpg")

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128

            ' Set background color of the barcode
            barCodeBuilder.BackColor = System.Drawing.Color.Yellow

            ' Set color (fore color) of the barcode
            barCodeBuilder.ForeColor = System.Drawing.Color.Blue

            ' Set border color of the barcode
            barCodeBuilder.BorderColor = System.Drawing.Color.Red

            ' Set color of the code text of the barcode
            barCodeBuilder.CodeTextColor = System.Drawing.Color.Red

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)
        End Sub
    End Class
End Namespace
