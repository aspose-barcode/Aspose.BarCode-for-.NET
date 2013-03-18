'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.BarCode

Namespace ManageXYDimension
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

			'Save the image to your system
			'and set its image format to Jpeg
			bb.Save(dataDir & "barcode.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

			'Set the X-Dimension for the bars of the barcode
			bb.xDimension = 0.5F

			'Set the measuring unit of barcode to millimeter
			bb.ImageUnit = System.Drawing.GraphicsUnit.Millimeter

			'Save the image to your system
			'and set its image format to Jpeg
			bb.Save(dataDir & "barcodeXDimensionChanged.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)


			'Instantiate barcode object
			Dim bb1 As New BarCodeBuilder()

			'Set the Code text for the barcode
			bb1.CodeText = "1234567"

			'Set the symbology type to Pdf417
			bb1.SymbologyType = Symbology.Pdf417

			'Set the Y-Dimension for the bars of the barcode
			bb1.yDimension = 4

			'Save the image to your system
			'and set its image format to Jpeg
			bb1.Save(dataDir & "barcodeYDimensionChanged.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
		End Sub
	End Class
End Namespace