Imports System.Drawing
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class SetFrameOut
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            ' Set Different properties
            Dim barCodeBuilder As New BarCodeBuilder("00850006000227", EncodeTypes.ITF14) With { _
                .AutoSize = True, _
                .ITF14BorderType = ITF14BorderType.FrameOut, _
                .CodeTextFont = New Font("OCR B Std", 8.0F), _
                .GraphicsUnit = GraphicsUnit.Millimeter, _
                .xDimension = 0.495F, _
                .BarHeight = 12.7F, _
                .CodeTextSpace = 0.5F, _
                .Resolution = New Resolution(1200.0F, 1200.0F, ResolutionMode.Customized) _
            }
            BarCodeBuilder.Save(dataDir & Convert.ToString("ITF14_Border_Type_FrameOut_out.png"), BarCodeImageFormat.Png)
        End Sub
    End Class
End Namespace