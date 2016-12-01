Imports System.Drawing
Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
	Class OptionalExceptionMessageWith1DBarCode
		Public Shared Sub Run()
			' ExStart:OptionalExceptionMessageWith1DBarCode
			' Instantiate BarCodeBuilder object
			Dim builder As New BarCodeBuilder("348503498549085409", EncodeTypes.EAN13)
			Try
				' Error message will not been thrown in case of false, default value is also false
				builder.ThrowExceptionWhenCodeTextIncorrect = True
                ' Get barcode image
				Dim bitmap As Bitmap = builder.GenerateBarCodeImage()
			Catch ex As Exception
				Console.WriteLine("Exception must be thrown, {0}", ex.Message)
			End Try
			' ExEnd:OptionalExceptionMessageWith1DBarCode
		End Sub
	End Class
End Namespace