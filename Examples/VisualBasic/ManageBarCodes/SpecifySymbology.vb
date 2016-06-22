Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SpecifySymbology
        Public Shared Sub Run()
            'ExStart:SpecifySymbology
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate BarCodeBuilder object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode-symbiology_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)
            ' ExStart:SpecifySymbology
        End Sub
    End Class
End Namespace