'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports System.IO
Imports Aspose.BarCode

Public Class CodabarStartStopSymbols
    Public Shared Sub Run()
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
        Dim dst As String = dataDir & Convert.ToString("Coabar-start-stop-symbols.png")

        ' Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
        Dim builder As New BarCodeBuilder("11112222333344", Symbology.Codabar)

        ' Set the codabar start symbol to A
        builder.CodabarStartSymbol = CodabarSymbol.A

        ' Set the codabar stop symbol to D
        builder.CodabarStopSymbol = CodabarSymbol.D

        ' Save the image to disk in PNG format
        builder.Save(dst)

        Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
    End Sub
End Class
