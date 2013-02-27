'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.BarCode

Namespace SaveBarcodeImagesToDifferentFormats
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate barcode object
			Dim bb As New BarCodeBuilder()

			'Set the Code text for the barcode
			bb.CodeText = "1234567"

			'Set the symbology type to Code128
			bb.SymbologyType = Symbology.Code128

			'Save the image to your system and set its image format to Jpeg
			bb.Save(dataDir & "barcode.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

			' Display Status.
			System.Console.WriteLine("Barcode saved to JPEG image successfully.")
		End Sub
	End Class
End Namespace