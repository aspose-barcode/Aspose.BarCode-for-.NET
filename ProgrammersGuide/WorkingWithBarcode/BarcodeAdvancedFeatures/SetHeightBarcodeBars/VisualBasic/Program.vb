'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.BarCode

Namespace SetHeightBarcodeBars
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate barcode object
			Dim lbc As New BarCodeBuilder()

			'Set the Code text for the barcode
			lbc.CodeText = "1234567"

			'Set the symbology type to Code128
			lbc.SymbologyType = Symbology.Code128

			'Set the bar height to 3 millimeters
			lbc.BarHeight = 3.0F

			'Set the measuring unit of barcode to millimeter
			lbc.ImageUnit = System.Drawing.GraphicsUnit.Millimeter

			'Save the image locally and set its image format to Jpeg
			lbc.Save(dataDir & "barcode3.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

			'Set the bar height to 3 millimeters
			lbc.BarHeight = 7.0F

			'Save the image locally and set its image format to Jpeg
			lbc.Save(dataDir & "barcode7.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

			'Set the bar height to 3 millimeters
			lbc.BarHeight = 11.0F

			'Save the image locally and set its image format to Jpeg
			lbc.Save(dataDir & "barcode11.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
		End Sub
	End Class
End Namespace