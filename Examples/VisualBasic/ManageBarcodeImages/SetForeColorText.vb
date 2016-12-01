'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetForeColorText
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()
            Dim dst As String = dataDir & Convert.ToString("barcode-SetForeColorText_out.jpg")

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text and text fore color to red for the barcode 
            barCodeBuilder.CodeText = "1234567"
            barCodeBuilder.CodeTextColor = System.Drawing.Color.Red
            Console.WriteLine(Convert.ToString(Environment.NewLine + "Barcode saved at ") & dst)
        End Sub
    End Class
End Namespace