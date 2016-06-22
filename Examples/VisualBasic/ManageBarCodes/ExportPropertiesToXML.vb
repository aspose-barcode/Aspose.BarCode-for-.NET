Imports System.Drawing
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class ExportPropertiesToXML
        Public Shared Sub Run()
            'ExStart:ExportPropertiesToXML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Initialize the BarCodeBuilder class by passing barcode text and barcode symbology as parameters.
            Dim builder As New BarCodeBuilder("abcdefghijklmnopqrstuvwxyzabcdef", Symbology.DataMatrix)

            ' set various different properties/variables of the barcode.
            builder.BorderVisible = True
            builder.ImageQuality = ImageQualityMode.AntiAlias
            builder.CodeLocation = CodeLocation.Above
            builder.Columns = 4
            builder.Rows = 3

            ' Specify caption settings.
            builder.CaptionAbove = New Caption("{Caption ABOVE}")
            builder.CaptionAbove.TextAlign = System.Drawing.StringAlignment.Center
            builder.CaptionAbove.Visible = True
            builder.CaptionAbove.ForeColor = Color.Green

            builder.CaptionBelow = New Caption("{Caption BELOW}")
            builder.CaptionBelow.TextAlign = System.Drawing.StringAlignment.Far
            builder.CaptionBelow.Visible = True
            builder.CaptionBelow.ForeColor = Color.Yellow

            ' Specify text font settings.
            builder.CodeTextFont = New Font("Courier New", 24, FontStyle.Bold Or FontStyle.Italic)

            ' call the export to XML method to export the properties to XML file.
            builder.ExportToXml(dataDir & Convert.ToString("BarCodeBuilder.DataMatrix_out.xml"))

            'ExEnd:ExportPropertiesToXML
            Console.WriteLine((Convert.ToString(Environment.NewLine + "Barcode saved at ") & dataDir) + "BarCodeBuilder.DataMatrix.xml")
        End Sub
    End Class
End Namespace