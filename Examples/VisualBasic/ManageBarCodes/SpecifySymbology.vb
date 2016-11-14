Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SpecifySymbology
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object and set differnt barcode properties
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128)

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode-symbiology_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)
        End Sub
    End Class
End Namespace