Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class RotateBarcode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object and set CodeText, Barcode Symbology and  hide code text
            Dim barCodeBuilder As New BarCodeBuilder("1234567890", EncodeTypes.QR) With { _
                .CodeLocation = CodeLocation.None, _
                .RotationAngleF = 90 _
            }
            BarCodeBuilder.Save(dataDir & Convert.ToString("QR-rotate_out.jpeg"), BarCodeImageFormat.Jpeg)
        End Sub
    End Class
End Namespace