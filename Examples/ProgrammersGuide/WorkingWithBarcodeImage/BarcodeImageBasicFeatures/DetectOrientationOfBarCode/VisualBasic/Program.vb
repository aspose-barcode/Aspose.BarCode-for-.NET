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
Imports Aspose.BarCodeRecognition
Imports System

Namespace DetectOrientationOfBarCode
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Instantiate BarCodeReader object
			Dim reader As New BarCodeReader(dataDir & "barcode.jpg", BarCodeReadType.Code128)

			Try
				' read Code128 bar code
				Do While reader.Read()
					' detect bar code orientation
					System.Console.Write("Rotaion Angle: " & reader.GetAngle())
				Loop
				reader.Close()

			Catch exp As Exception

				System.Console.Write(exp.Message)
			End Try
		End Sub
	End Class
End Namespace