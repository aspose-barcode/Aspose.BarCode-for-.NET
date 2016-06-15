Imports System.IO
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.Programming.BarCode

    Public Class ChecksumSupplementData
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ProgrammingBarCode()
            Dim dst As String = dataDir & Convert.ToString("code39-checeksum.png")

            'Instantiate barcode object
            Dim bb As New BarCodeBuilder()

            'Set the Code text for the barcode
            bb.CodeText = "1234567"

            'Set the symbology type to Code39
            bb.SymbologyType = Symbology.Code39Standard

            'Make the checksum to be visible on the barcode
            bb.EnableChecksum = EnableChecksum.Yes

            'Save the image to your system
            'and set its image format to Jpeg
            bb.Save(dst)

            Console.WriteLine(Environment.NewLine + "Barcode saved at " & dst)
        End Sub
    End Class
End Namespace