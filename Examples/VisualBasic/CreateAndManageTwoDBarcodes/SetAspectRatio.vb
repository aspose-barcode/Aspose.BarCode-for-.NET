Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class SetAspectRatio
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' Create instance of BarCodeBuilder class, Set Aspect Ratio to 3:2 or 1.5 and Save the barcode image to disk in PNG format  
            Dim barCodeBuilder As New BarCodeBuilder("1234567890", EncodeTypes.Pdf417)
            barCodeBuilder.AspectRatio = 1.5F
            barCodeBuilder.Save(dataDir & Convert.ToString("SetAspectRatio_out.png"), BarCodeImageFormat.Png)
        End Sub
    End Class
End Namespace