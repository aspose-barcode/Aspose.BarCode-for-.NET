Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.Programming.BarCode

    Public Class ManageXYDimension
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
            Dim dstCode128 As String = dataDir & Convert.ToString("code128-YDimensionChanged.jpg")
            Dim dstPdf417 As String = dataDir & Convert.ToString("pdf417-YDimensionChanged.jpg")

            'Instantiate barcode object
            Dim bb As New BarCodeBuilder()

            'Set the Code text for the barcode
            bb.CodeText = "1234567"

            'Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128

            'Save the image to your system
            'and set its image format to Jpeg
            bb.Save(dstCode128, System.Drawing.Imaging.ImageFormat.Jpeg)

            'Set the X-Dimension for the bars of the barcode
            bb.xDimension = 0.5F

            'Set the measuring unit of barcode to millimeter
            bb.GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter

            'Save the image to your system
            'and set its image format to Jpeg
            bb.Save(dstCode128, System.Drawing.Imaging.ImageFormat.Jpeg)


            'Instantiate barcode object
            Dim bb1 As New BarCodeBuilder()

            'Set the Code text for the barcode
            bb1.CodeText = "1234567"

            'Set the symbology type to Pdf417
            bb1.SymbologyType = Symbology.Pdf417

            'Set the Y-Dimension for the bars of the barcode
            bb1.yDimension = 4

            'Save the image to your system
            'and set its image format to Jpeg
            bb1.Save(dstPdf417, System.Drawing.Imaging.ImageFormat.Jpeg)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dstCode128)
            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dstPdf417)
        End Sub
    End Class
End Namespace