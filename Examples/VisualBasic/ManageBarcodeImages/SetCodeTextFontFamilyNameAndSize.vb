Imports System.IO
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class SetCodeTextFontFamilyNameAndSize
        Public Shared Sub Run()

            'ExStart:SetCodeTextFontFamilyNameAndSize
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set Code text font's type and size
            barCodeBuilder.CodeTextFont = New System.Drawing.Font("Verdana", 12.0F)

            ' Save barcode image to file
            barCodeBuilder.Save(dataDir & Convert.ToString("SetCodeTextFontFamilyNameAndSize_out.bmp"), System.Drawing.Imaging.ImageFormat.Bmp)
            'ExEnd:SetCodeTextFontFamilyNameAndSize            

            Console.WriteLine(Convert.ToString(Environment.NewLine + "Barcode saved at ") & dataDir)
        End Sub
    End Class
End Namespace