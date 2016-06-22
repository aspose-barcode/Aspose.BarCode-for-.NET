Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class WideNarrowRatio
        Public Shared Sub Run()

            'ExStart:WideNarrowRatio
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate linear barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567"

            ' Set the symbology type to Code39
            barCodeBuilder.SymbologyType = Symbology.Code39Standard

            ' Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 3.0F

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode_ratio_3_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 5.0F

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode_ratio_5_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 7.0F

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("barcode_ratio_7_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            ' Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 9.0F

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir & Convert.ToString("code39-wide-narrow-ratio_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)
            'ExEnd:WideNarrowRatio

            Console.WriteLine((Convert.ToString(Environment.NewLine + "Barcode saved at ") & dataDir) + "code39-wide-narrow-ratio_out.png")
        End Sub
    End Class
End Namespace