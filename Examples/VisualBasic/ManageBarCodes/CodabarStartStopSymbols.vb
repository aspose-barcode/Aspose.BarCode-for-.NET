Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CodabarStartStopSymbols
        Public Shared Sub Run()
            'ExStart:CodabarStartStopSymbols
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            Dim builder As New BarCodeBuilder("11112222333344", Symbology.Codabar)

            ' Set the codabar start symbol to A
            builder.CodabarStartSymbol = CodabarSymbol.A

            ' Set the codabar stop symbol to D
            builder.CodabarStopSymbol = CodabarSymbol.D

            ' Save the image to disk in PNG format
            builder.Save(dataDir & Convert.ToString("Coabar-start-stop-symbols_out.png"))
            'ExEnd:CodabarStartStopSymbols
        End Sub
    End Class
End Namespace