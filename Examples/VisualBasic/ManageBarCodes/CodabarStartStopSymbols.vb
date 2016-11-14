Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CodabarStartStopSymbols
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            ' Set the codabar start symbol to A and stop symbol to D
            Dim builder As New BarCodeBuilder("11112222333344", EncodeTypes.Codabar) With { _
                .CodabarStartSymbol = CodabarSymbol.A, _
                .CodabarStopSymbol = CodabarSymbol.D _
            }
            builder.Save(dataDir & Convert.ToString("Coabar-start-stop-symbols_out.png"))
        End Sub
    End Class
End Namespace