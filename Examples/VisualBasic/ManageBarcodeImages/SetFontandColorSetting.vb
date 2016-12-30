Imports System.Drawing

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodeImages
    Class SetFontandColorSetting
        Public Shared Sub Run()
            'ExStart:SetFontandColorSetting
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodesImages()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()
            barCodeBuilder.CaptionAbove.TextAlign = StringAlignment.Near
            barCodeBuilder.CaptionAbove.Text = "Aspose.Demo"
            barCodeBuilder.CaptionAbove.Visible = True
            barCodeBuilder.CaptionAbove.Font = New System.Drawing.Font("Pristina", 14.0F)
            barCodeBuilder.CaptionAbove.ForeColor = Color.OrangeRed
            barCodeBuilder.CaptionBelow.TextAlign = StringAlignment.Far
            barCodeBuilder.CaptionBelow.Text = "Aspose.Demo"
            barCodeBuilder.CaptionBelow.Visible = True
            barCodeBuilder.CaptionBelow.Font = New System.Drawing.Font("Pristina", 14.0F)
            barCodeBuilder.CaptionBelow.ForeColor = Color.OrangeRed
            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("SetFontandColorSetting.jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg)
            Console.WriteLine(Convert.ToString(Environment.NewLine + "Barcode saved at ") & dataDir)
            'ExEnd:SetFontandColorSetting
        End Sub
    End Class
End Namespace
