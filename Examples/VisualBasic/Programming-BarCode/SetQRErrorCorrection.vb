'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports System.IO
Imports Aspose.BarCode

Public Class SetQRErrorCorrection
    Public Shared Sub Run()
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
        Dim dst As String = dataDir & Convert.ToString("QR-error-correction.jpg")

        ' Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
        Dim builder As Aspose.BarCode.BarCodeBuilder
        builder = New Aspose.BarCode.BarCodeBuilder()
        builder.SymbologyType = Aspose.BarCode.Symbology.QR
        builder.QRErrorLevel = QRErrorLevel.LevelH
        builder.CodeText = "1234567890"
        builder.Save(dst, BarCodeImageFormat.Jpeg)

        Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
    End Sub
End Class
