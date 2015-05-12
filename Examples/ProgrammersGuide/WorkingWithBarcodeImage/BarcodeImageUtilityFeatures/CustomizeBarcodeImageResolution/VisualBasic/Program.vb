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

Namespace CustomizeBarcodeImageResolution
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
			Dim bb As New BarCodeBuilder()

			'Set the Code text for the barcode
			bb.CodeText = "1234567"

			'Set the symbology type to Code128
			bb.SymbologyType = Symbology.Code128

			'Create an instance of resolution and apply on the barcode image with
			'customized resolution settings
			bb.Resolution = New Resolution(200f, 400f, ResolutionMode.Customized)

			'Save the image to your system
			'and set its image format to Jpeg
			bb.Save(dataDir & "barcode.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

		End Sub
	End Class
End Namespace