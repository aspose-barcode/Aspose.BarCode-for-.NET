Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetHeightOfBarsInDataBarStackedOmniDirectional
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object, Set the SymbologyType and Height and Resolution for barcode
            Dim builder As New BarCodeBuilder("(01)90013670000396(3200)15(11)150819", EncodeTypes.DatabarStackedOmniDirectional) With { _
                .xDimension = 0.33F, _
                .BarHeight = 27.77F, _
                .Resolution = New Resolution(1200.0F, 1200.0F, ResolutionMode.Customized) _
            }
            ' Save the image to your system and set its image format to Jpeg
            builder.Save(dataDir & Convert.ToString("Barheight_out.png"), BarCodeImageFormat.Png)
        End Sub
    End Class
End Namespace