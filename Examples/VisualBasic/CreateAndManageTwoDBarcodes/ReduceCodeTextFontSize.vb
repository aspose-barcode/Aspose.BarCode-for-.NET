Imports System.IO
Imports System.Text
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class ReduceCodeTextFontSize
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            'ExStart:ReduceCodeTextFontSize
            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set CodeText 
            barCodeBuilder.CodeText = "The quick brown fox jumps over the lazy dog" & vbLf + "The quick brown fox jumps over the lazy dog" & vbLf



            ' Set Barcode Symbology
            barCodeBuilder.SymbologyType = Symbology.DataMatrix

            ' Set Barcode CodeLocation
            barCodeBuilder.CodeLocation = CodeLocation.None

            ' Save the Barcode image
            barCodeBuilder.Save(dataDir & Convert.ToString("HideBarcodeCodeText_out.png"), BarCodeImageFormat.Png)
            'ExEnd:ReduceCodeTextFontSize
        End Sub
    End Class
End Namespace