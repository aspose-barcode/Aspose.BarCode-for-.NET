Imports System.IO
Imports Aspose.BarCode
Imports VisualBasic.Aspose.BarCode.Examples.VisualBasic

Namespace Aspose.BarCode.Examples.VisualBasic

    Public Class BarcodeImageBorders
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_BarCodeImage()
            Dim dst As String = dataDir & Convert.ToString("barcode-image-borders.jpg")

            'Instantiate barcode object
            Dim bb As New BarCodeBuilder()

            'Set border style to solid
            bb.BorderDashStyle = Aspose.BarCode.BorderDashStyle.Solid

            'Set border margins by assigning an instance of MarginsF
            bb.Margins = New Aspose.BarCode.MarginsF(2.0F, 2.0F, 2.0F, 2.0F)

            'Set border width
            bb.BorderWidth = 0.5F

            'Enable border to be shown in the barcode
            bb.BorderVisible = True

            'Save the image to your system
            'and set its image format to Jpeg
            bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace