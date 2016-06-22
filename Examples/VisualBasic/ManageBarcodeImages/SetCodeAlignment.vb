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
    Class SetCodeAlignment
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()
            Dim dst As String = dataDir & Convert.ToString("barcode-SetCodeAlignment_out.jpg")

            'ExStart:SetCodeAlignment
            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' lign the code text to center
            barCodeBuilder.CodeTextAlignment = System.Drawing.StringAlignment.Center

            'ExEnd:SetCodeAlignment            
            Console.WriteLine(Convert.ToString(Environment.NewLine + "Barcode saved at ") & dst)
        End Sub
    End Class
End Namespace
