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
    Class SetAspectRatio
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            'ExStart:SetAspectRatio
            ' Create instance of BarCodeBuilder class

            Dim builder As New BarCodeBuilder("1234567890", Symbology.Pdf417)
            ' Set Aspect Ratio to 3:2 or 1.5

            builder.AspectRatio = 1.5F
            ' Save the barcode image to disk in PNG format

            builder.Save(dataDir & Convert.ToString("SetAspectRatio_out.png"), BarCodeImageFormat.Png)
            'ExEnd:SetAspectRatio
        End Sub
    End Class
End Namespace