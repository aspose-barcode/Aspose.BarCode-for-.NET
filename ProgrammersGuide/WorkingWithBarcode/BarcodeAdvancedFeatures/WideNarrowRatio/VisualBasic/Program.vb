'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.BarCode

Namespace WideNarrowRatio
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate linear barcode object
			Dim bb As New BarCodeBuilder()

			'Set the Code text for the barcode
			bb.CodeText = "1234567"

			'Set the symbology type to Code39
			bb.SymbologyType = Symbology.Code39Standard

			'Set the wide to narrow ratio for the barcode
			bb.WideNarrowRatio = 3.0F

			'Save the image to your system
			'and set its image format to Jpeg
			bb.Save(dataDir & "barcode_ratio_3.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

			'Set the wide to narrow ratio for the barcode
			bb.WideNarrowRatio = 5.0F

			'Save the image to your system
			'and set its image format to Jpeg
			bb.Save(dataDir & "barcode_ratio_5.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

			'Set the wide to narrow ratio for the barcode
			bb.WideNarrowRatio = 7.0F

			'Save the image to your system
			'and set its image format to Jpeg
			bb.Save(dataDir & "barcode_ratio_7.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

			'Set the wide to narrow ratio for the barcode
			bb.WideNarrowRatio = 9.0F

			'Save the image to your system
			'and set its image format to Jpeg
			bb.Save(dataDir & "barcode_ratio_9.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
		End Sub
	End Class
End Namespace