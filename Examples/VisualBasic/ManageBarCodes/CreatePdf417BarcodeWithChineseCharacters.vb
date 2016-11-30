Imports System.Text
Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
	Class CreatePdf417BarcodeWithChineseCharacters
		Public Shared Sub Run()
			' ExStart:CreatePdf417BarcodeWithChineseCharacters
			' The path to the documents directory.
			Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()
			Const  codetext As String = "被洪水困住的"

            ' Generate the barcode and Encode the code text     
			Dim builder As New BarCodeBuilder(codetext, EncodeTypes.Pdf417)
            Dim bytes As Byte() = Encoding.GetEncoding(936).GetBytes(codetext)
			builder.SetBinaryCodeText(bytes)

			' Set the display text
			builder.Display2DText = codetext
			builder.Save(dataDir & Convert.ToString("CreatePdf417BarcodeWithChineseCharacters_out.png"))
			' ExEnd:CreatePdf417BarcodeWithChineseCharacters
		End Sub
	End Class
End Namespace