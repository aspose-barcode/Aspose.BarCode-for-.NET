Imports System.Drawing
Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class SpecifyITF14BorderThicknes
        Public Shared Sub Run()
            'ExStart:SpecifyITF14BorderThicknes
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object and Set Different Properties
            Dim barCodeBuilder As New BarCodeBuilder("00850006000227", EncodeTypes.ITF14) With { _
                .AutoSize = True, _
                .ITF14BorderType = ITF14BorderType.BarOut, _
                .CodeTextFont = New Font("OCR B Std", 8.0F), _
                .GraphicsUnit = GraphicsUnit.Millimeter, _
                .xDimension = 0.495F, _
                .BarHeight = 12.7F, _
                .CodeTextSpace = 0.5F, _
                .Resolution = New Resolution(1200.0F, 1200.0F, ResolutionMode.Customized) _
            }
            barCodeBuilder.Save(dataDir & Convert.ToString("ITF14_Border_TypeBar_Out.png"), BarCodeImageFormat.Png)
            'ExEnd:SpecifyITF14BorderThicknes
        End Sub
    End Class
End Namespace