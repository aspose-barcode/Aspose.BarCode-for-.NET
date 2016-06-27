Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class RotateBarcode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate BarCodeBuilder object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the symbology type 
            barCodeBuilder.SymbologyType = Symbology.QR

            ' Set the Code Text 
            barCodeBuilder.CodeText = "1234567890"

            ' hide code text
            barCodeBuilder.CodeLocation = CodeLocation.None
            barCodeBuilder.RotationAngleF = 90
            barCodeBuilder.Save(dataDir & Convert.ToString("QR-rotate_out.jpeg"), BarCodeImageFormat.Jpeg)
        End Sub
    End Class
End Namespace
