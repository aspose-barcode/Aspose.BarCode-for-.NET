Imports System.Drawing.Imaging
Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class CreateEnCodeDatamatrixBarCode
        Public Shared Sub Run()
            'ExStart:CreateEnCodeDatamatrixBarCode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' Instantiate barcode object and set CodeText & Barcode Symbology and Set Data Matrix EncodeMode 
            Dim barCodeBuilder As New BarCodeBuilder("This is the data to be encoded", EncodeTypes.DataMatrix)
            barCodeBuilder.DataMatrixEncodeMode = Aspose.BarCode.DataMatrixEncodeMode.ASCII
            barCodeBuilder.Save(dataDir & Convert.ToString("ManagePDF417Barcode_out.bmp"), ImageFormat.Bmp)
            'ExEnd:CreateEnCodeDatamatrixBarCode
        End Sub
    End Class
End Namespace