Imports System.IO
Imports Aspose.BarCode
Imports System.Drawing.Printing

Namespace Aspose.BarCode.Examples.VisualBasic.BarCode.Image.Utility.Features

    Public Class SetSizeUnitForBarcodeImage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_BarCodeImage()
            Dim dst As String = dataDir & Convert.ToString("barcode-size-unit.jpg")

            'Instantiate barcode object
            Dim bb As New BarCodeBuilder()

            'Set the Code text for the barcode
            bb.CodeText = "1234567"

            'Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128

            'Set the bar height to 3 points
            bb.BarHeight = 3.0F

            'Set the measuring unit of barcode to point
            bb.GraphicsUnit = System.Drawing.GraphicsUnit.Point

            'Save the image to your system
            'and set its image format to Jpeg
            bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace