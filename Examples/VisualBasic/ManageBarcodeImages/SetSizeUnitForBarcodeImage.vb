Imports System.IO
Imports Aspose.BarCode
Imports System.Drawing.Printing
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class SetSizeUnitForBarcodeImage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object
            ' Set the bar height to 3 points and measuring unit of barcode to point
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128) With { _
                .BarHeight = 3.0F, _
                .GraphicsUnit = System.Drawing.GraphicsUnit.Point _
            }
            BarCodeBuilder.Save(dataDir & Convert.ToString("barcode-size-unit_out.jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg)
        End Sub
    End Class
End Namespace