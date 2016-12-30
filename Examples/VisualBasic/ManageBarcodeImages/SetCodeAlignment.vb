'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class SetCodeAlignment
        Public Shared Sub Run()
            'ExStart:SetCodeAlignment
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()
            Dim dst As String = dataDir & Convert.ToString("barcode-SetCodeAlignment_out.jpg")

            ' Instantiate barcode object and set differnt Properties.
            Dim barCodeBuilder As New BarCodeBuilder()
            barCodeBuilder.CodeText = "1234567"
            barCodeBuilder.CodeTextAlignment = System.Drawing.StringAlignment.Center
            Console.WriteLine(Convert.ToString(Environment.NewLine + "Barcode saved at ") & dst)
            'ExEnd:SetCodeAlignment
        End Sub
    End Class
End Namespace
