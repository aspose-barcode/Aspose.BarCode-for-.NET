'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports System.IO
Imports Aspose.BarCode

Public Class BarcodeImageBorders
    Public Shared Sub Run()
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_BarCodeImage()
        Dim dst As String = dataDir & Convert.ToString("barcode-image-borders.jpg")

        'Instantiate barcode object
        Dim bb As New BarCodeBuilder()

        'Set border style to solid
        bb.BorderDashStyle = Aspose.BarCode.BorderDashStyle.Solid

        'Set border margins by assigning an instance of MarginsF
        bb.Margins = New Aspose.BarCode.MarginsF(2.0F, 2.0F, 2.0F, 2.0F)

        'Set border width
        bb.BorderWidth = 0.5F

        'Enable border to be shown in the barcode
        bb.BorderVisible = True

        'Save the image to your system
        'and set its image format to Jpeg
        bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)

        Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
    End Sub
End Class
