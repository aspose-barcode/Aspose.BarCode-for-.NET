Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CodabarStartStopSymbols
        Public Shared Sub Run()
            'ExStart:CodabarStartStopSymbols

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Create instance of BarCodeBuilder, specify codetext and symbology in the constructor also set codabar start symbol to A and stop symbol to D
            Dim builder As New BarCodeBuilder("11112222333344", EncodeTypes.Codabar) With { _
                .CodabarStartSymbol = CodabarSymbol.A, _
                .CodabarStopSymbol = CodabarSymbol.D _
            }
            builder.Save(dataDir & Convert.ToString("Coabar-start-stop-symbols_out.png"))
            'ExEnd:CodabarStartStopSymbols
        End Sub
    End Class
End Namespace