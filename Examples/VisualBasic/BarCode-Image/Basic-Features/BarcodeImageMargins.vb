'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports System.IO
Imports Aspose.BarCode

Public Class BarcodeImageMargins
    Public Shared Sub Run()
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_BarCodeImage()
        Dim dst As String = dataDir & Convert.ToString("barcode-image-margins.jpg")

        'Instantiate barcode object
        Dim bb As New BarCodeBuilder()

        'Set the Code text for the barcode
        bb.CodeText = "1234567"

        'Set the symbology type to Code128
        bb.SymbologyType = Symbology.Code128

        ' sets the left margin
        bb.Margins.Left = 0.5F

        ' sets the right margin
        bb.Margins.Right = 0.0F

        ' sets the top margin
        bb.Margins.Top = 0.0F

        ' sets the bottom margin
        bb.Margins.Bottom = 0.0F

        'Save the image to your system
        'and set its image format to Jpeg
        bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)

        Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
    End Sub
End Class
