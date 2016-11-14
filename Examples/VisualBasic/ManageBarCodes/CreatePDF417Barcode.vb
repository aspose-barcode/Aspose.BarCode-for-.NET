Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CreatePDF417Barcode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate BarCodeBuilder object Set the Code text & SymbologyType for the barcode
            Dim barCodeBuilder As New BarCodeBuilder("1234567890", EncodeTypes.Pdf417)
            barCodeBuilder.Save(dataDir & Convert.ToString("pdf417-barcode_out.jpg"), BarCodeImageFormat.Jpeg)
        End Sub
    End Class
End Namespace