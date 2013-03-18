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
Imports Aspose.Words.Drawing
Imports Aspose.BarCodeRecognition

Namespace RecognizeBarcodeFromWord
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Load the word document
			Dim wordDocument As New Document(dataDir & "input.doc")

			' get all the shapes
			Dim shapes As NodeCollection = wordDocument.GetChildNodes(NodeType.Shape, True, False)

			' loop through all the shapes
			For Each shape As Shape In shapes
				' check if it has an image
				If shape.HasImage Then
					' save the image in memory stream
					Dim imgStream As New MemoryStream()
					shape.ImageData.Save(imgStream)

					' recognize the barcode from the image stream above
					Dim reader As New BarCodeReader(New Bitmap(imgStream), BarCodeReadType.Code39Standard)
					Do While reader.Read()
						Console.WriteLine("Codetext found: " & reader.GetCodeText())
					Loop

					' close the reader
					reader.Close()
				End If
			Next shape
		End Sub
	End Class
End Namespace