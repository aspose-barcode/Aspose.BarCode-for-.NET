'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.BarCode
Imports Aspose.Words

Namespace IntegrateWithAsposeWords
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate barcode object
			Dim bb As New BarCodeBuilder()

			'Set the Code text for the barcode
			bb.CodeText = "1234567"

			'Set the symbology type to Code39Standard
			bb.SymbologyType = Symbology.Code39Standard

			Dim ms As New MemoryStream()

			bb.Save(ms, BarCodeImageFormat.Bmp)

			'Create doc with Aspose.Word
			Dim doc As New Document()

			'Create builder for doc
			Dim builder As New DocumentBuilder(doc)

			'Insert the BarCode image into doc
			builder.InsertImage(ms.GetBuffer())

			' Close memory stream.
			ms.Close()

			' Save the file
			doc.Save(dataDir & "Myfile.doc")

			System.Console.WriteLine("Myfile.doc file with embedded barcode image is created." & vbLf)
		End Sub
	End Class
End Namespace