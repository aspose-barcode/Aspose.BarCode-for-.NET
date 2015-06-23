'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports System.IO
Imports Aspose.BarCode

Public Class BarcodeImageQuality
    Public Shared Sub Run()
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_BarCodeImage()
        Dim dst As String = dataDir & Convert.ToString("barcode-image-quality.jpg")

        'Instantiate barcode object
        Dim bb As New BarCodeBuilder()

        'Set the Code text for the barcode
        bb.CodeText = "1234567"

        'Set the symbology type to Code128
        bb.SymbologyType = Symbology.Code128

        'Set the image quality mode to anti alias
        bb.ImageQuality = ImageQualityMode.AntiAlias

        'Save the image to your system
        'and set its image format to Jpeg
        bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)

        Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
    End Sub
End Class
