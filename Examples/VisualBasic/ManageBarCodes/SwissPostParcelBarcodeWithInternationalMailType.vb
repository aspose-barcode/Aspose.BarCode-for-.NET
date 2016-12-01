Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
	Class SwissPostParcelBarcodeWithInternationalMailType
		Public Shared Sub Run()
			' ExStart:SwissPostParcelBarcodeWithInternationalMailType
			' The path to the documents directory.
			Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

			' Generate the barcode and Save barcode on local
			Dim builder As New BarCodeBuilder("RA121212122CH", EncodeTypes.SwissPostParcel)
			builder.Save(dataDir & Convert.ToString("SwissPostParcelBarcodeWithInternationalMailType_out.png"))
			' ExEnd:SwissPostParcelBarcodeWithInternationalMailType
		End Sub
	End Class
End Namespace