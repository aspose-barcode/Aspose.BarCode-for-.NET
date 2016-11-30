Imports System.Drawing.Printing
Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class PrintBarcodeImage
        Public Shared Sub Run()
            ' Get the default Printer Name
            Dim settings As New PrinterSettings()
            Dim printerName As String = settings.PrinterName

            ' Instantiate barcode object and set CodeText & Barcode Symbology and Set printer name
            Dim barCodeBuilder As New BarCodeBuilder("1234567890", EncodeTypes.Code128)
            barCodeBuilder.PrinterName = printerName
            barCodeBuilder.Print()
        End Sub
    End Class
End Namespace