Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class ChecksumSupplementData
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' Set the symbology type to Code39
            barCodeBuilder.SymbologyType = Symbology.Code39Standard

            ' Make the checksum to be visible on the barcode
            barCodeBuilder.EnableChecksum = EnableChecksum.Yes

            ' Save the image to your system and set its image format to png
            barCodeBuilder.Save(dataDir & Convert.ToString("code39-checeksum_out.png"))
            Console.WriteLine((Convert.ToString(Environment.NewLine + "Barcode saved at ") & dataDir) + "code39-checeksum.png")
        End Sub
    End Class
End Namespace