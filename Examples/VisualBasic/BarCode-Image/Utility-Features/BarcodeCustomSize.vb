'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports System.IO
Imports Aspose.BarCode

Public Class BarcodeCustomSize
    Public Shared Sub Run()
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_BarCodeImage()
        Dim dst As String = dataDir & Convert.ToString("barcode-custom-size.jpg")

        'Instantiate barcode object
        Dim builder As New BarCodeBuilder("1234567890", Symbology.Code39Standard)

        ' Set auto size false
        builder.AutoSize = False

        ' Set height
        builder.ImageHeight = 50

        ' Set width
        builder.ImageWidth = 120

        ' Save image to disk
        builder.Save(dst)

        Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
    End Sub
End Class
