Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class WideNarrowRatio
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate linear barcode object
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code39Standard)

            ' Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 3.0F

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode_ratio_3_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 5.0F

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode_ratio_5_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 7.0F

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode_ratio_7_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 9.0F

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("code39-wide-narrow-ratio_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

        End Sub
    End Class
End Namespace