Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetSupplementData
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object
            ' Set the supplement data (5 Digit)
            Dim barCodeBuilder As New BarCodeBuilder("123456789123", EncodeTypes.EAN13) With { _
                .SupplementData = "12345", _
                .SupplementSpace = 2.0F _
            }
            BarCodeBuilder.Save(dataDir & Convert.ToString("SetSupplementData_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)
        End Sub
    End Class
End Namespace