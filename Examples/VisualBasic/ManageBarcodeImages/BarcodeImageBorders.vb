Imports System.IO
Imports System.Drawing.Imaging
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class BarcodeImageBorders
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set border style to solid
            barCodeBuilder.BorderDashStyle = BorderDashStyle.Solid

            ' Set border margins by assigning an instance of MarginsF
            barCodeBuilder.Margins = New MarginsF(2.0F, 2.0F, 2.0F, 2.0F)

            ' Set border width
            barCodeBuilder.BorderWidth = 0.5F

            ' Enable border to be shown in the barcode
            barCodeBuilder.BorderVisible = True

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcodeImageborders_out.jpeg"), ImageFormat.Jpeg)

        End Sub
    End Class
End Namespace