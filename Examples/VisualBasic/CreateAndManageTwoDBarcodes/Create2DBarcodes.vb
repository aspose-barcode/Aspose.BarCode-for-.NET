Imports System.IO
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class Create2DBarcodes
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set Barcode Symbology
            barCodeBuilder.SymbologyType = Symbology.Pdf417

            ' width of each module
            barCodeBuilder.xDimension = 0.6F

            ' height of each module
            barCodeBuilder.yDimension = 1.2F
            barCodeBuilder.CodeText = "this is some test code text. " & vbLf & " Second line " & vbLf & " third line."

            ' Save the Barcode image
            barCodeBuilder.Save(dataDir & Convert.ToString("2d-barcode_out.jpg"), BarCodeImageFormat.Jpeg)
            Console.WriteLine((Convert.ToString(Environment.NewLine + "Barcode saved at ") & dataDir) + "2d-barcode.jpg")
        End Sub
    End Class
End Namespace