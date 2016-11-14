Imports System.IO
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetCodeText
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object and set differnt barcode properties
            Dim barCodeBuilder As New BarCodeBuilder("1234567", EncodeTypes.Code128) With { _
                .xDimension = 1.0F _
            }

            ' Save the image to your system and set its image format to Jpeg
            BarCodeBuilder.Save(dataDir & Convert.ToString("barcode-codetext_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)
            Console.WriteLine((Convert.ToString(Environment.NewLine + "Barcode saved at ") & dataDir) + "barcode-codetext_out.jpg")
        End Sub
    End Class
End Namespace