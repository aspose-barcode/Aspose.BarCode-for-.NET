'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports System.IO
Imports Aspose.BarCode

Public Class GenerateAustraliaPostBarcode
    Public Shared Sub Run()
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()

        ' Set codetext
        Dim codeText As String = "12345678"

        ' Initialize BarCodeBuilder
        Dim builder As New BarCodeBuilder(codeText, Symbology.AustraliaPost)

        ' Set format control code to standard
        builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Standard
        ' Save the image to disk in PNG format
        builder.Save(dataDir & Convert.ToString("AustraliaPost-Standard.png"))

        ' Set format control code to ReplyPaid
        builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.ReplyPaid
        ' Save the image to disk in PNG format
        builder.Save(dataDir & Convert.ToString("AustraliaPost-ReplyPaid.png"))

        ' Set format control code to Customer2
        builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Customer2
        ' Save the image to disk in PNG format
        builder.Save(dataDir & Convert.ToString("AustraliaPost-Customer2.png"))

        ' Set format control code to Customer3
        builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Customer3
        ' Save the image to disk in PNG format
        builder.Save(dataDir & Convert.ToString("AustraliaPost-Customer3.png"))

        ' Set format control code to Routing
        builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Routing
        ' Save the image to disk in PNG format
        builder.Save(dataDir & Convert.ToString("AustraliaPost-Routing.png"))

        ' Set format control code to Redirection
        builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Redirection
        ' Save the image to disk in PNG format
        builder.Save(dataDir & Convert.ToString("AustraliaPost-Redirection.png"))

        Console.WriteLine(Environment.NewLine + "AustraliaPost Barcodes saved at " & dataDir)
    End Sub
End Class
