Imports System.Text
Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
	Class RecognizeBarcodeWithTurkishCharacters
		Public Shared Sub Run()
			Try
				' ExStart:RecognizeBarcodeWithTurkishCharacters
				' The path to the documents directory.
				Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

                ' Load barcode image and Read barcode
				Dim reader = New BarCodeReader(dataDir & Convert.ToString("Turkish.png"), DecodeType.Pdf417)
                While reader.Read()
                    Dim t = reader.GetCodeBytes()
                    Dim encodingValue = Encoding.GetEncoding(1254).GetString(t)
                End While
                reader.Close()
                ' ExEnd:RecognizeBarcodeWithTurkishCharacters
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
			End Try
		End Sub
	End Class
End Namespace