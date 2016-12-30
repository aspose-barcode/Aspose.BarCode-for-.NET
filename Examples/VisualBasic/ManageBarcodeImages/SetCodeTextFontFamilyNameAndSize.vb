'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class SetCodeTextFontFamilyNameAndSize
        Public Shared Sub Run()
            'ExStart:SetCodeTextFontFamilyNameAndSize
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object, Set Code text font' S type and size, Save barcode image to file
            Dim barCodeBuilder As New BarCodeBuilder()
            barCodeBuilder.CodeTextFont = New System.Drawing.Font("Verdana", 12.0F)
            barCodeBuilder.Save(dataDir & Convert.ToString("SetCodeTextFontFamilyNameAndSize_out.bmp"), System.Drawing.Imaging.ImageFormat.Bmp)
            Console.WriteLine(Convert.ToString(Environment.NewLine + "Barcode saved at ") & dataDir)
            'ExEnd:SetCodeTextFontFamilyNameAndSize
        End Sub
    End Class
End Namespace