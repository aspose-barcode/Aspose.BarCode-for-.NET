Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.Programming.BarCode

    Public Class WideNarrowRatio
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
            Dim dst As String = dataDir & Convert.ToString("code39-wide-narrow-ratio.png")

            'Instantiate linear barcode object
            Dim bb As New BarCodeBuilder()

            'Set the Code text for the barcode
            bb.CodeText = "1234567"

            'Set the symbology type to Code39
            bb.SymbologyType = Symbology.Code39Standard

            'Set the wide to narrow ratio for the barcode
            bb.WideNarrowRatio = 3.0F

            'Save the image to your system
            'and set its image format to Jpeg
            bb.Save(dataDir & Convert.ToString("barcode_ratio_3.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            'Set the wide to narrow ratio for the barcode
            bb.WideNarrowRatio = 5.0F

            'Save the image to your system
            'and set its image format to Jpeg
            bb.Save(dataDir & Convert.ToString("barcode_ratio_5.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            'Set the wide to narrow ratio for the barcode
            bb.WideNarrowRatio = 7.0F

            'Save the image to your system
            'and set its image format to Jpeg
            bb.Save(dataDir & Convert.ToString("barcode_ratio_7.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            'Set the wide to narrow ratio for the barcode
            bb.WideNarrowRatio = 9.0F

            'Save the image to your system
            'and set its image format to Jpeg
            bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace