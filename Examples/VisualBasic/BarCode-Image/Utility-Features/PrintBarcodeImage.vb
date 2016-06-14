Imports System.IO
Imports Aspose.BarCode
Imports System.Drawing.Printing

Namespace Aspose.BarCode.Examples.VisualBasic.BarCode.Image.Utility.Features

    Public Class PrintBarcodeImage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_BarCodeImage()
            Dim dst As String = dataDir & Convert.ToString("barcode-print.jpg")

            'Get the default Printer Name
            Dim settings As New PrinterSettings()

            Dim printerName As String = settings.PrinterName

            ' Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            Dim builder As New BarCodeBuilder("12345678", Symbology.Code128)

            ' Set printer name
            builder.PrinterName = printerName

            builder.Print()

            Console.WriteLine(Environment.NewLine + "Printing barcode.... ")
        End Sub
    End Class
End Namespace