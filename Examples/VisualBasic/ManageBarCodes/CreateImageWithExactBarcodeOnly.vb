Imports System.Drawing
Imports System.Drawing.Imaging
Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CreateImageWithExactBarcodeOnly
        Public Shared Sub Run()
            Try
                ' ExStart:CreateImageWithExactBarcodeOnly
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

                ' Generate the barcode and set code text, symbology type
                Dim builder As New BarCodeBuilder("123456", EncodeTypes.Code128)

                ' Get bitmap with exact barcode only and Save image on local disk
                Dim bmp As Bitmap = builder.GetOnlyBarCodeImage()
                bmp.Save(dataDir & Convert.ToString("CreateImageWithExactBarcodeOnly_out.png"), ImageFormat.Png)
                ' ExEnd:CreateImageWithExactBarcodeOnly
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace