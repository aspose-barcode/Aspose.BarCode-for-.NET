Imports System.Drawing
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class SpecifyITF14BorderThicknes
        Public Shared Sub Run()
            'ExStart:SpecifyITF14BorderThicknes
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder("00850006000227")
            barCodeBuilder.AutoSize = True

            ' Set Barcode Symbology
            barCodeBuilder.SymbologyType = Symbology.ITF14

            ' Set ITF14 Barcode Border Type
            barCodeBuilder.ITF14BorderType = ITF14BorderType.BarOut

            ' Set Font
            barCodeBuilder.CodeTextFont = New Font("OCR B Std", 8.0F)

            ' Set Measuring Units
            barCodeBuilder.GraphicsUnit = GraphicsUnit.Millimeter

            ' Set xDimension
            barCodeBuilder.xDimension = 0.495F

            ' Set Bars Height
            barCodeBuilder.BarHeight = 12.7F

            ' specify space between characters
            barCodeBuilder.CodeTextSpace = 0.5F

            ' Define resolution and its mode
            barCodeBuilder.Resolution = New Resolution(1200.0F, 1200.0F, ResolutionMode.Customized)

            ' Save the Barcode image
            barCodeBuilder.Save(dataDir & Convert.ToString("ITF14_Border_TypeBar_Out.png"), BarCodeImageFormat.Png)
            'ExEnd:SpecifyITF14BorderThicknes

        End Sub
    End Class
End Namespace
