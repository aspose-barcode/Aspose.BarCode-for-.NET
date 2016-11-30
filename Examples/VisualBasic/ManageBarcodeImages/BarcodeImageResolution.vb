Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class BarcodeImageResolution
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Create an instance of resolution and apply on the barcode image with customized resolution settings
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128) With { _
                .Resolution = New Resolution(200.0F, 400.0F, ResolutionMode.Customized) _
            }

            ' Save the image to your system and set its image format to Jpeg
            BarCodeBuilder.Save(dataDir & Convert.ToString("barcode-image-resolution_out.jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg)
        End Sub
    End Class
End Namespace