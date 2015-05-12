'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.BarCode
Imports Aspose.BarCodeRecognition

Namespace RecognizeBarcodeFromPdf
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Try
				' bind the pdf document
				Dim pdfExtractor As New Aspose.Pdf.Facades.PdfExtractor()
				pdfExtractor.BindPdf(dataDir & "document.pdf")

				' set page range for image extraction
				pdfExtractor.StartPage = 1
				pdfExtractor.EndPage = 1

				' extract the images
				System.Console.WriteLine("Extracting images.....")
				pdfExtractor.ExtractImage()

				' save images to stream in a loop
				Do While pdfExtractor.HasNextImage()
					System.Console.WriteLine("Getting next image....")

					' save image to stream
					Dim imageStream As New MemoryStream()
					pdfExtractor.GetNextImage(imageStream)
					imageStream.Position = 0

					System.Console.WriteLine("Recognizing barcode....")

					' recognize the barcode from the image stream above
					Dim barcodeReader As New Aspose.BarCodeRecognition.BarCodeReader(imageStream, BarCodeReadType.Code39Standard)
					Do While barcodeReader.Read()
						System.Console.WriteLine("Codetext found: " & barcodeReader.GetCodeText() & ", Symbology: " & barcodeReader.GetReadType().ToString())
					Loop
					' close the reader
					barcodeReader.Close()
				Loop
			Catch ex As Exception
				System.Console.WriteLine(ex.Message)
			End Try
		End Sub
	End Class
End Namespace