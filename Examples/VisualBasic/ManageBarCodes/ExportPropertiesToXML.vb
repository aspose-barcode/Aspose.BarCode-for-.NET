Imports System.Drawing
Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class ExportPropertiesToXML
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Initialize the BarCodeBuilder class by passing barcode text and barcode symbology as parameters also Set various different properties/variables of the barcode.
            Dim builder As New BarCodeBuilder("abcdefghijklmnopqrstuvwxyzabcdef", EncodeTypes.DataMatrix) With { _
                .BorderVisible = True, _
                .ImageQuality = ImageQualityMode.AntiAlias, _
                .CodeLocation = CodeLocation.Above, _
                .Columns = 4, _
                .Rows = 3, _
                .CaptionAbove = New Caption("{Caption ABOVE}") With { _
                    .TextAlign = System.Drawing.StringAlignment.Center, _
                    .Visible = True, _
                    .ForeColor = Color.Green _
                } _
            }

            ' Specify caption settings.
            builder.CaptionBelow = New Caption("{Caption BELOW}")
            builder.CaptionBelow.TextAlign = System.Drawing.StringAlignment.Far
            builder.CaptionBelow.Visible = True
            builder.CaptionBelow.ForeColor = Color.Yellow

            ' Specify text font settings.
            builder.CodeTextFont = New Font("Courier New", 24, FontStyle.Bold Or FontStyle.Italic)

            ' Call the export to XML method to export the properties to XML file.
            builder.ExportToXml(dataDir & Convert.ToString("BarCodeBuilder.DataMatrix_out.xml"))
        End Sub
    End Class
End Namespace