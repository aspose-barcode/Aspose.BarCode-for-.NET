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

Namespace GenerateBarcodeCustomSize
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Instantiate barcode object
			Dim builder As New BarCodeBuilder("1234567890", Symbology.Code39Standard)

			' Set auto size false
			builder.AutoSize = False

			' Set height
			builder.ImageHeight = 50

			' Set width
			builder.ImageWidth = 120

			' Save image to disk
			builder.Save(dataDir & "test.png")


		End Sub
	End Class
End Namespace