Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.Programming.BarCode

    Public Class SetHeightBarcodeBars
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
            Dim dst As String = dataDir & Convert.ToString("Code128-bar-height.png")

            'Instantiate barcode object
            Dim lbc As New BarCodeBuilder()

            'Set the Code text for the barcode
            lbc.CodeText = "1234567"

            'Set the symbology type to Code128
            lbc.SymbologyType = Symbology.Code128

            'Set the bar height to 3 millimeters
            lbc.BarHeight = 3.0F

            'Set the measuring unit of barcode to millimeter
            lbc.GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter

            'Save the image locally and set its image format to Jpeg
            lbc.Save(dataDir & Convert.ToString("barcode3.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            'Set the bar height to 3 millimeters
            lbc.BarHeight = 7.0F

            'Save the image locally and set its image format to Jpeg
            lbc.Save(dataDir & Convert.ToString("barcode7.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            'Set the bar height to 3 millimeters
            lbc.BarHeight = 11.0F

            'Save the image locally and set its image format to Jpeg
            lbc.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace