Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CodetextAppearance
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()
            Dim dst As String = dataDir & Convert.ToString("codetext-appearence_out.jpg")

            ' Set the symbology type to Code128
            ' set differnt barcode properties
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128) With { _
                .CodeTextAlignment = System.Drawing.StringAlignment.Center, _
                 .CodeLocation = CodeLocation.Above, _
                .CodeTextColor = System.Drawing.Color.Red, _
                .CodeTextSpace = 1.0F _
            }
            barCodeBuilder.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)
        End Sub
    End Class
End Namespace