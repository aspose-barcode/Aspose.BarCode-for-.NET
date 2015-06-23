'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports System.IO
Imports Aspose.BarCode
Imports System.Drawing.Printing

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
