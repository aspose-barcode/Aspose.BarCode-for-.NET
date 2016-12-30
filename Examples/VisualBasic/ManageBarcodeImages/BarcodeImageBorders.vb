Imports System.Drawing.Imaging

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class BarcodeImageBorders
        Public Shared Sub Run()
            'ExStart:BarcodeImageBorders
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set border style to solid
            barCodeBuilder.BorderDashStyle = BorderDashStyle.Solid

            ' Set border margins by assigning an instance of MarginsF
            barCodeBuilder.Margins = New MarginsF(2.0F, 2.0F, 2.0F, 2.0F)

            ' Set border width, Enable border to be shown in the barcode and Save the image.
            barCodeBuilder.BorderWidth = 0.5F
            barCodeBuilder.BorderVisible = True
            barCodeBuilder.Save(dataDir & Convert.ToString("barcodeImageborders_out.jpeg"), ImageFormat.Jpeg)
            'ExEnd:BarcodeImageBorders
        End Sub
    End Class
End Namespace