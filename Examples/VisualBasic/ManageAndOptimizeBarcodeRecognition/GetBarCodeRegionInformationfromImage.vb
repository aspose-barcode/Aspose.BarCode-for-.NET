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
    Class GetBarCodeRegionInformationfromImage
        Public Shared Sub Run()
            'ExStart:GetBarCodeRegionInformationfromImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

            ' Create an instance of BarCodeReader class and read barcode file
            Dim barCodeReader As New BarCodeReader(dataDir & Convert.ToString("Region.png"), DecodeType.Code39Standard)

            ' Try to recognize all possible barcodes in the image
            While barCodeReader.Read()

                ' Get the region information
                Dim region As BarCodeRegion = barCodeReader.GetRegion()
                If region IsNot Nothing Then
                    ' Display x and y coordinates of barcode detected
                    Dim point As Point() = region.Points
                    Console.WriteLine("Top left coordinates: X = " + point(0).X.ToString() + ", Y = " + point(0).Y.ToString())
                    Console.WriteLine("Top right coordinates: X = " + point(1).X.ToString() + ", Y = " + point(1).Y.ToString())
                    Console.WriteLine("Bottom right coordinates: X = " + point(2).X.ToString() + ", Y = " + point(2).Y.ToString())
                    Console.WriteLine("Bottom left coordinates: X = " + point(3).X.ToString() + ", Y = " + point(3).Y.ToString())
                End If
                Console.WriteLine("Codetext: " + barCodeReader.GetCodeText())
            End While
            ' Close reader
            barCodeReader.Close()
            'ExEnd:GetBarCodeRegionInformationfromImage
        End Sub
    End Class
End Namespace