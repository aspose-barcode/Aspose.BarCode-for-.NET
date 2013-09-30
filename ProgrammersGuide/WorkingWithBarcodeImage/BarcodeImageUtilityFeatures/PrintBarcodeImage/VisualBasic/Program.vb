'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.BarCode
Imports System.Drawing.Printing

Namespace PrintBarcodeImage
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Get the default Printer Name
			Dim settings As New PrinterSettings()

			Dim printerName As String = settings.PrinterName

			' Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
			Dim builder As New BarCodeBuilder("12345678", Symbology.Code128)

			' Set printer name
			builder.PrinterName = printerName

			builder.Print()

		End Sub
	End Class
End Namespace