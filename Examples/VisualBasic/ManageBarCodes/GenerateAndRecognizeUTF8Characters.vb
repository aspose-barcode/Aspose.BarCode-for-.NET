Imports System.Drawing
Imports System.Text
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
	Class GenerateAndRecognizeUTF8Characters
		Public Shared Sub Run()
			Try
				' ExStart:GenerateAndRecognizeUTF8Characters
				' The path to the documents directory.
				Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

				' Generate the barcode
				Dim imgBarcode As Bitmap = Nothing
                Dim objBarCodeBuilder As New BarCodeBuilder() With { _
                    .EncodeType = EncodeTypes.MacroPdf417 _
                }

				' Set the codetext by converting it into unicode byte array
				Dim byteArray As Byte() = Encoding.Unicode.GetBytes("منحة")
				objBarCodeBuilder.SetBinaryCodeText(byteArray)
				imgBarcode = objBarCodeBuilder.GenerateBarCodeImage()
				imgBarcode.Save(dataDir & Convert.ToString("GenerateAndRecognizeUTF8Characters_out.png"))

				' Recognize the above barcode
				Dim reader As New BarCodeReader(dataDir & Convert.ToString("GenerateAndRecognizeUTF8Characters_out.png"))
				While reader.Read()
					Dim unicode As Encoding = Encoding.Unicode

					' Get the characters array from the bytes
					Dim unicodeChars As Char() = New Char(unicode.GetCharCount(reader.GetCodeBytes(), 0, reader.GetCodeBytes().Length) - 1) {}
					unicode.GetChars(reader.GetCodeBytes(), 0, reader.GetCodeBytes().Length, unicodeChars, 0)

					' Build unicode string
					Dim strCodeText As New String(unicodeChars)
					System.Console.WriteLine(strCodeText)
				End While
					' ExEnd:GenerateAndRecognizeUTF8Characters
				reader.Close()
			Catch ex As Exception
				Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
			End Try
		End Sub
	End Class
End Namespace