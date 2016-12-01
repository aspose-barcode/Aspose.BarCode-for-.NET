Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetWideNarrowRatio
        Public Shared Sub Run()
            ' ExStart:SetWideNarrowRatio
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Set X dimension reduction property of barcode and save barcode Image
            Dim barCodeBuilder As New BarCodeBuilder("blackReduction", EncodeTypes.Code128) With { _
                .xDimension = 1.2F, _
                .BarWidthReduction = 0.2F _
            }
            BarCodeBuilder.Save(dataDir & Convert.ToString("SetWideNarrowRatio_out.png"))
            ' ExEnd:SetWideNarrowRatio
        End Sub
    End Class
End Namespace