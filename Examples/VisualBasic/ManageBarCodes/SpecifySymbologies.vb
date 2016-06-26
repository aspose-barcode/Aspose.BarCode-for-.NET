Imports System.IO
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SpecifySymbologies
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object
            Dim bb As New BarCodeBuilder()

            ' Set the Code text for the barcode
            bb.CodeText = "1234567"

            ' Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128

            ' Save the image to your system and set its image format to Jpeg
            bb.Save(dataDir & Convert.ToString("barcode-SpecifySymbologies_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)
        End Sub
    End Class
End Namespace
