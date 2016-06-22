Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class BarcodeCustomSize
        Public Shared Sub Run()
            'ExStart:BarcodeCustomSize
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object
            Dim builder As New BarCodeBuilder("1234567890", Symbology.Code39Standard)

            ' Set auto size false
            builder.AutoSize = False

            ' Set height
            builder.ImageHeight = 50

            ' Set width
            builder.ImageWidth = 120

            ' Save image to disk
            builder.Save(dataDir & Convert.ToString("barcode-custom-size_out.jpg"))
            'ExEnd:BarcodeCustomSize
        End Sub
    End Class
End Namespace