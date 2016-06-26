Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetHeightOfBarsInDataBarStackedOmniDirectional
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object
            Dim builder As New BarCodeBuilder("(01)90013670000396(3200)15(11)150819")

            ' Set the SymbologyType and Height and Resolution for barcode
            builder.SymbologyType = Symbology.DatabarStackedOmniDirectional
            builder.xDimension = 0.33F
            builder.BarHeight = 27.77F
            builder.Resolution = New Resolution(1200.0F, 1200.0F, ResolutionMode.Customized)

            ' Save the image to your system and set its image format to Jpeg
            builder.Save(dataDir & Convert.ToString("Barheight_out.png"), BarCodeImageFormat.Png)
        End Sub
    End Class
End Namespace