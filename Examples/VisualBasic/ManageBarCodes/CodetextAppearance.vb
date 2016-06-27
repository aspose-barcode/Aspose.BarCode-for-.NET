Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CodetextAppearance
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()
            Dim dst As String = dataDir & Convert.ToString("codetext-appearence.jpg")

            ' Instantiate bar code object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the bar code
            barCodeBuilder.CodeText = "1234567"

            ' Align the code text to center
            barCodeBuilder.CodeTextAlignment = System.Drawing.StringAlignment.Center

            ' Set the location of the code text to above the bar code
            barCodeBuilder.CodeLocation = CodeLocation.Above

            ' Set the code text fore color to red
            barCodeBuilder.CodeTextColor = System.Drawing.Color.Red

            ' Increase the space between code text and barcode to 1 point
            barCodeBuilder.CodeTextSpace = 1.0F

            ' Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128

            ' Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg)

            Console.WriteLine(Convert.ToString(Environment.NewLine + "Barcode saved at ") & dst)
        End Sub
    End Class
End Namespace