Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class GenerateAustraliaPostBarcode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Set codetext
            Dim codeText As String = "1159628792"

            ' Initialize BarCodeBuilder and Set format control code to standard
            Dim builder As New BarCodeBuilder(codeText, EncodeTypes.AustraliaPost)
            builder.Save(dataDir & Convert.ToString("AustraliaPost-Standard_out.png"))
        End Sub
    End Class
End Namespace