Imports System.IO
Imports Aspose.BarCode.Examples.CSharp
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class ManageCaption
        Public Shared Sub Run()
            
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128

            ' Create caption object. Set its text and text alignment & also make it visible
            Dim caption As New Caption()
            caption.Text = "Aspose.BarCode"
            caption.TextAlign = System.Drawing.StringAlignment.Center
            caption.Visible = True

            ' Assign caption object to be displayed above and below the barcode
            barCodeBuilder.CaptionAbove = caption
            barCodeBuilder.CaptionBelow = caption

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("ManageCaption_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)
            Console.WriteLine(Convert.ToString(Environment.NewLine + "Barcode saved at ") & dataDir)
        End Sub
    End Class
End Namespace