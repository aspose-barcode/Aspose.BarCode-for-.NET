Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CodetextAppearance
        Public Shared Sub Run()
            'ExStart:CodetextAppearance
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()
            Dim dst As String = dataDir & Convert.ToString("codetext-appearence_out.jpg")

            ' Create instance of BarCodeBuilder Set the symbology type to Code128 and differnt barcode properties
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128) With { _
                .CodeTextAlignment = System.Drawing.StringAlignment.Center, _
                 .CodeLocation = CodeLocation.Above, _
                .CodeTextColor = System.Drawing.Color.Red, _
                .CodeTextSpace = 1.0F _
            }
            barCodeBuilder.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)
            'ExEnd:CodetextAppearance
        End Sub
    End Class
End Namespace