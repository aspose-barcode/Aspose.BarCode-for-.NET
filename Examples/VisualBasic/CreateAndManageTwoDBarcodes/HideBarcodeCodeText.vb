Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class HideBarcodeCodeText
        Public Shared Sub Run()
            'ExStart:HideBarcodeCodeText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()
            Dim codeText As String = "The quick brown fox jumps over the lazy dog" & vbLf + "The quick brown fox jumps over the lazy dog" & vbLf

            ' Instantiate barcode object and set CodeText, Symbology , and  CodeLocation
            Dim barCodeBuilder As New BarCodeBuilder(codeText, EncodeTypes.DataMatrix)
            barCodeBuilder.CodeLocation = CodeLocation.None
            barCodeBuilder.Save(dataDir & Convert.ToString("HideBarcodeCodeText_out.png"), BarCodeImageFormat.Png)
            'ExEnd:HideBarcodeCodeText
        End Sub
    End Class
End Namespace
