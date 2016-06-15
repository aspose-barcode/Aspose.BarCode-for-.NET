Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.BarCode.Image.Basic.Features

    Public Class RotateBarcodeImage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_BarCodeImage()
            Dim dst As String = dataDir & Convert.ToString("barcode-image-rotate.jpg")

            'Instantiate barcode object
            Dim bb As New BarCodeBuilder()

            'Set the Code text for the barcode
            bb.CodeText = "1234567"

            'Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128

            'Set the rotation angle of the barcode to 180 degree
            bb.RotationAngleF = 180

            'Save the image to your system
            'and set its image format to Jpeg
            bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace