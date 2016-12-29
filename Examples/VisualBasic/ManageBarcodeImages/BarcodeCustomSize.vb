Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class BarcodeCustomSize
        Public Shared Sub Run()
            'ExStart:BarcodeCustomSize
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object and set CodeText, Barcode Symbology and other           
            Dim builder As New BarCodeBuilder("1234567890", EncodeTypes.Code39Standard) With { _
                .AutoSize = False, _
                .ImageHeight = 50, _
                .ImageWidth = 120 _
            }
            builder.Save(dataDir & Convert.ToString("barcode-custom-size_out.jpg"))
            'ExEnd:BarcodeCustomSize
        End Sub
    End Class
End Namespace