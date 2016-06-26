Imports System.Drawing.Imaging
Imports System.Text
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'


Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class CustomEncodingModeInDataMatrix
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set Barcode Symbology
            barCodeBuilder.SymbologyType = Symbology.DataMatrix

            ' Set Data Matrix EncodeMode to Custom
            barCodeBuilder.DataMatrixEncodeMode = DataMatrixEncodeMode.[Custom]

            ' Set CodeText Encoding Property 
            barCodeBuilder.CodeTextEncoding = Encoding.UTF8

            ' Set CodeText for barcode          
            barCodeBuilder.CodeText = "Г¶Г¤ГјГ©Г ГЁ"

            barCodeBuilder.Save(dataDir & Convert.ToString("CustomEncodingModeInDataMatrix_out.bmp"), ImageFormat.Bmp)
        End Sub
    End Class
End Namespace