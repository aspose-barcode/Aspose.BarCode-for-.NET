Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetHeightBarcodeBars
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object and set differnt barcode properties
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128) With { _
                .BarHeight = 3.0F, _
                .GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter _
            }

            ' Save the image locally and set its image format to Jpeg
            BarCodeBuilder.Save(dataDir & Convert.ToString("barcode3_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Set the bar height to 3 millimeters and Save the image locally and set its image format to Jpeg
            BarCodeBuilder.BarHeight = 7.0F
            BarCodeBuilder.Save(dataDir & Convert.ToString("barcode7_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Set the bar height to 3 millimeters and  Save the image to disk
            BarCodeBuilder.BarHeight = 11.0F
            BarCodeBuilder.Save(dataDir & Convert.ToString("Code128-bar-height_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)
        End Sub
    End Class
End Namespace