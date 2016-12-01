Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class GeneratingGS1ForCodablock
        Public Shared Sub Run()
            ' ExStart:GeneratingGS1ForCodablock
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Create instance of BarCodeBuilder class.
            Dim b As New BarCodeBuilder()

            ' Specify code text, Set encode type and  Save the image to disk in PNG format
            b.CodeText = "(01)03412345678900(17)010200"
            b.EncodeType = EncodeTypes.GS1CodablockF
            b.BarCodeImage.Save("GS1CodablockF_out.png")
            ' ExEnd:GeneratingGS1ForCodablock
        End Sub
    End Class
End Namespace
