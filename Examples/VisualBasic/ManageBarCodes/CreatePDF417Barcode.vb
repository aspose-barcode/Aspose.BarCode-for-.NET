Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CreatePDF417Barcode
        Public Shared Sub Run()
            ' ExStart:CreatePDF417Barcode 
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate BarCodeBuilder object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the SymbologyType for the barcode
            barCodeBuilder.SymbologyType = Symbology.Pdf417

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567890"

            ' Save file to disk
            barCodeBuilder.Save(dataDir & Convert.ToString("pdf417-barcode_out.jpg"), BarCodeImageFormat.Jpeg)
            ' ExEnd:CreatePDF417Barcode 
        End Sub
    End Class
End Namespace
