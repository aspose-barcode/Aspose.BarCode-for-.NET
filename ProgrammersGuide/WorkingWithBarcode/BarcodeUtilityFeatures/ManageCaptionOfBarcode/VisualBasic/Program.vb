'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.BarCode

Namespace ManageCaptionOfBarcode
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If Not IsExists Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If
			
			'Instantiate barcode object
			Dim bb As New BarCodeBuilder()

			'Set the Code text for the barcode
			bb.CodeText = "1234567"

			'Set the symbology type to Code128
			bb.SymbologyType = Symbology.Code128

			bb.CaptionAbove.Visible = False

			'Create caption object. Set its text and text alignment & also make it visible
			Dim caption As New Caption()
			caption.Text = "Aspose"
			caption.TextAlign = System.Drawing.StringAlignment.Center
			caption.Visible = True
			caption.Font = New System.Drawing.Font("Pristina", 14F)
			caption.ForeColor = System.Drawing.Color.Red

			'Assign caption object to be displayed above the barcode
			bb.CaptionAbove = caption

			Dim captionBelow As New Caption()
			captionBelow.Text = "Aspose.BarCode Caption Below"
			captionBelow.TextAlign = System.Drawing.StringAlignment.Center
			captionBelow.Visible = True
			captionBelow.Font = New System.Drawing.Font("Pristina", 14F)
			captionBelow.ForeColor = System.Drawing.Color.OrangeRed

			'Assign caption object to be displayed below the barcode
			bb.CaptionBelow = captionBelow

			'Save the image to your system and set its image format to Jpeg
			bb.Save(dataDir & "barcode.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
		End Sub
	End Class
End Namespace