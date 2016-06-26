Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetCodeText
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate BarCodeBuilder object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128

            ' Set the width of the bars to 1 millimeters
            barCodeBuilder.xDimension = 1.0F

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode-codetext_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)
            Console.WriteLine((Convert.ToString(Environment.NewLine + "Barcode saved at ") & dataDir) + "barcode-codetext_out.jpg")
        End Sub
    End Class
End Namespace