Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CreateDatamatrixBarcode
        Public Shared Sub Run()
            'ExStart:CreateDatamatrixBarcode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate BarCodeBuilder object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the SymbologyType for the barcode
            barCodeBuilder.SymbologyType = Symbology.DataMatrix

            ' Set the CodeText for the barcode
            barCodeBuilder.CodeText = "1234567890"

            ' Save file to disk
            barCodeBuilder.Save(dataDir & Convert.ToString("datamatrix-barcode_out.jpg"), BarCodeImageFormat.Jpeg)
            'ExEnd:CreateDatamatrixBarcode

            Console.WriteLine((Convert.ToString(Environment.NewLine + "Barcode saved at ") & dataDir) + "datamatrix-barcode_out.jpg")
        End Sub
    End Class
End Namespace
