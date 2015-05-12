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

Namespace CustomizeCode128Barcodes
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			' Create Code12 barcode in mixed mode (Code128 A and B)
			Dim code12Builder As New Code128CodeBuilder(Code128CodeSet.A)

			Dim codeText As String = code12Builder.Append("1234").SwitchTo(Code128CodeSet.B).Append("5678").ToString()

			Dim builder As New BarCodeBuilder(codeText, Symbology.Code128)

			' Save the image to disk in PNG format
			builder.Save(dataDir & "test.png")

		End Sub
	End Class
End Namespace