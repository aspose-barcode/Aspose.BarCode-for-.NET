Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class SaveBarcodeImageToStreams
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128)

            ' Create a memory stream object that would store barcode image in binary form
            Dim mStream As New System.IO.MemoryStream()

            ' Call save method of BarCodeImage to store Png barcode image to memory stream
            barCodeBuilder.BarCodeImage.Save(dataDir & mStream.ToString() & "_out.png", System.Drawing.Imaging.ImageFormat.Png)
        End Sub
    End Class
End Namespace