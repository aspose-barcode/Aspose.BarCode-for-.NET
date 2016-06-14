Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.BarCode_Image.Basic_Features

    Public Class ColorizeAnyPartoftheBarcodeImage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_BarCodeImage()
            Dim dst As String = dataDir & Convert.ToString("colorize-barcode.jpg")

            'Instantiate barcode object
            Dim bb As New BarCodeBuilder()

            'Set the Code text for the barcode
            bb.CodeText = "1234567"

            'Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128

            'Set background color of the barcode
            bb.BackColor = System.Drawing.Color.Yellow

            'Set color (fore color) of the barcode
            bb.ForeColor = System.Drawing.Color.Blue

            'Set border color of the barcode
            bb.BorderColor = System.Drawing.Color.Red

            'Set color of the code text of the barcode
            bb.CodeTextColor = System.Drawing.Color.Red

            'Save the image to your system
            'and set its image format to Jpeg
            bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace