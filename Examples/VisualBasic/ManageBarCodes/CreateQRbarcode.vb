Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CreateQRbarcode
        Public Shared Sub Run()
            'ExStart:CreateQRbarcode

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Initialize BarCodeBuilder
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Smbology Type
            barCodeBuilder.SymbologyType = Symbology.QR

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567890"

            ' Save the file on disk and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("CreateQRbarcode_out.bmp"), BarCodeImageFormat.Bmp)
            'ExEnd:CreateQRbarcode
        End Sub
    End Class
End Namespace
