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
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports Aspose.BarCodeRecognition
Imports System.Drawing.Imaging

Namespace PdfToImagesToBarCode
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim pdfDocument As New Document(dataDir & "document.pdf")
			Dim pageCount As Integer = pdfDocument.Pages.Count

			For i = 1 To pageCount
				Dim converter = New PdfConverter()
				converter.BindPdf(dataDir & "document.pdf")
				converter.StartPage = i
				converter.EndPage = i
				converter.DoConvert()

				Dim stream As New MemoryStream()
				converter.GetNextImage(stream, ImageFormat.Png)
				Using reader As New BarCodeReader(stream, BarCodeReadType.Code39Standard)
					Do While reader.Read()
						System.Console.WriteLine("Page#" & i & " -- Symbol:" & reader.GetReadType() & " Code :" & reader.GetCodeText())
					Loop
				End Using
				converter.Close()
				converter.Dispose()
			Next i

		End Sub
	End Class
End Namespace