Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CreateDatamatrixBarcode
        Public Shared Sub Run()
            'ExStart:CreateDatamatrixBarcode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            Dim barCodeBuilder As New BarCodeBuilder("1234567890", EncodeTypes.DataMatrix)
            barCodeBuilder.Save(dataDir & Convert.ToString("datamatrix-barcode_out.jpg"), BarCodeImageFormat.Jpeg)
            'ExEnd:CreateDatamatrixBarcode
        End Sub
    End Class
End Namespace