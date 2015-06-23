'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports System.IO
Imports Aspose.BarCode

Public Class CreateCode128Barcode
    Public Shared Sub Run()
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
        Dim dst As String = dataDir & Convert.ToString("Code128-customized.png")

        ' Set codetext
        Dim codeText As String = "1234"

        ' Initialize BarCodeBuilder
        Dim builder As New BarCodeBuilder(codeText, Symbology.Code128)
        ' Code128 type handles Code A, B and C character sets automatically

        ' Save the image to disk in PNG format
        builder.Save(dst)

        Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
    End Sub
End Class
