Imports System.IO
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'


Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class GetBarCodeRegionInformationfromImage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

            ' create an instance of BarCodeReader class and read barcode file
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
        End Sub
    End Class
End Namespace