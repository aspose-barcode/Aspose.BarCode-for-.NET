Imports System.IO
Imports System.Drawing.Printing
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class PrintBarcodeImage
        Public Shared Sub Run()
            ' Get the default Printer Name
            Dim settings As New PrinterSettings()

            Dim printerName As String = settings.PrinterName

            ' Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            Dim builder As New BarCodeBuilder("12345678", Symbology.Code128)

            ' Set printer name
            builder.PrinterName = printerName

            builder.Print()
        End Sub
    End Class
End Namespace