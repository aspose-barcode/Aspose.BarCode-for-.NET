Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CreateQRbarcode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            Dim barCodeBarCodeBuilder As New BarCodeBuilder("1234567890", EncodeTypes.QR)
            barCodeBarCodeBuilder.Save(dataDir & Convert.ToString("CreateQRbarcode_out.bmp"), BarCodeImageFormat.Bmp)
        End Sub
    End Class
End Namespace
