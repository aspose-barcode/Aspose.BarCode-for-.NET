'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports System.IO
Imports Aspose.BarCode

Public Class Create2DBarcodes
    Public Shared Sub Run()
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
        Dim dst As String = dataDir & Convert.ToString("2d-barcode.jpg")

        Dim b As Aspose.BarCode.BarCodeBuilder
        b = New Aspose.BarCode.BarCodeBuilder()
        b.SymbologyType = Aspose.BarCode.Symbology.Pdf417
        ' width of each module
        b.xDimension = 0.6F
        ' height of each module
        b.yDimension = 1.2F
        b.CodeText = "this is some test code text. " & vbLf & " Second line " & vbLf & " third line."
        b.Save(dst, BarCodeImageFormat.Jpeg)

        Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
    End Sub
End Class
