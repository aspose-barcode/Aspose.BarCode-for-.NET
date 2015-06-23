'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports System.IO
Imports Aspose.BarCode

Public Class CreateQRbarcode
    Public Shared Sub Run()
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
        Dim dst As String = dataDir & Convert.ToString("QR.jpg")

        Dim b As Aspose.BarCode.BarCodeBuilder
        b = New Aspose.BarCode.BarCodeBuilder()
        b.SymbologyType = Aspose.BarCode.Symbology.QR
        b.CodeText = "1234567890"
        b.Save(dst, BarCodeImageFormat.Bmp)

        Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
    End Sub
End Class
