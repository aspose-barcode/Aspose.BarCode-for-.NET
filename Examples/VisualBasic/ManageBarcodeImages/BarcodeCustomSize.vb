Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class BarcodeCustomSize
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            ' Set auto size false, height and width
            Dim builder As New BarCodeBuilder("1234567890", EncodeTypes.Code39Standard) With { _
                .AutoSize = False, _
                .ImageHeight = 50, _
                .ImageWidth = 120 _
            }
            builder.Save(dataDir & Convert.ToString("barcode-custom-size_out.jpg"))
        End Sub
    End Class
End Namespace