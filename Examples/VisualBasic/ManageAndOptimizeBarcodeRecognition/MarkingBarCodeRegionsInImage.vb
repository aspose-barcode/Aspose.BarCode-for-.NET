Imports System.Drawing
Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class MarkingBarCodeRegionsInImage
        Public Shared Sub Run()
            'ExStart:MarkingBarCodeRegionsInImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

            ' Create an instance of BarCodeReader and set image and symbology type to recognize
            Dim barCodeReader As New BarCodeReader(dataDir & Convert.ToString("code39.png"), DecodeType.Code39Standard)
            Dim counter As Integer = 0

            ' Read all the barcodes from the images
            While barCodeReader.Read()

                ' Display the symbology type and codetext
                Console.WriteLine("BarCode Type: " & barCodeReader.GetCodeType().ToString())
                Console.WriteLine("BarCode CodeText: " & barCodeReader.GetCodeText().ToString())

                ' Get the barcode region
                Dim region As BarCodeRegion = barCodeReader.GetRegion()
                If region IsNot Nothing Then
                    ' Initialize an object of type Image to get the Graphics object
                    Dim image__1 As Image = Image.FromFile(dataDir & Convert.ToString("code39.png"))

                    ' Initialize graphics object from the image
                    Dim graphics__2 As Graphics = Graphics.FromImage(image__1)

                    ' Draw the barcode edges and Save the image
                    region.DrawBarCodeEdges(graphics__2, New Pen(Color.Red, 1.0F))
                    image__1.Save(dataDir & String.Format("edge_{0}.png", System.Math.Max(System.Threading.Interlocked.Increment(counter), counter - 1)))

                    ' Fill the barcode area with some color
                    region.FillBarCodeRegion(graphics__2, Brushes.Green)
                    image__1.Save(dataDir & String.Format("fill_{0}.png", System.Math.Max(System.Threading.Interlocked.Increment(counter), counter - 1)))
                End If
            End While
            barCodeReader.Close()
            'ExEnd:MarkingBarCodeRegionsInImage
        End Sub
    End Class
End Namespace