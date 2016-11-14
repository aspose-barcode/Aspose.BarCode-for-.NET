Imports System.IO
Imports Aspose.BarCode
Imports System.Drawing.Printing
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class PrintBarcodeImage
        Public Shared Sub Run()
            ' Get the default Printer Name
            Dim settings As New PrinterSettings()
            Dim printerName As String = settings.PrinterName

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            Dim barCodeBuilder As New BarCodeBuilder("1234567890", EncodeTypes.Code128)

            ' Set printer name
            barCodeBuilder.PrinterName = printerName
            barCodeBuilder.Print()
        End Sub
    End Class
End Namespace