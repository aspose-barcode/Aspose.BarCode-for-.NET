
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
    Class GetAllPossible1DBarcodesfromImage
        Public Shared Sub Run()
            Try
                'ExStart:GetAllPossible1DBarcodesfromImage               
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

                ' Initialize the BarCodeReader object
                Dim reader As New BarCodeReader(dataDir & Convert.ToString("Barcode2.png"), DecodeType.AllSupportedTypes)
                ' Call read memthod
                reader.Read()

                ' Now get all possible barcodes
                Dim barcodes As BarCodeReader.PossibleBarCode() = reader.GetAllPossibleBarCodes()

                For Each barcode As BarCodeReader.PossibleBarCode In barcodes
                    ' Display code text, symbology, detected angle, recognition percentage of the barcode
                    Console.WriteLine("Code Text: " & barcode.Codetext.ToString() & " Symbology: " & barcode.BarCodeReadType.ToString() & " Recognition percentage: " + barcode.Angle)

                    ' Display x and y coordinates of barcode detected
                    Dim point As System.Drawing.Point() = barcode.Region.Points
                    Console.WriteLine("Top left coordinates: X = " + point(0).X + ", Y = " + point(0).Y)
                    Console.WriteLine("Bottom left coordinates: X = " + point(1).X + ", Y = " + point(1).Y)
                    Console.WriteLine("Bottom right coordinates: X = " + point(2).X + ", Y = " + point(2).Y)
                    Console.WriteLine("Top right coordinates: X = " + point(3).X + ", Y = " + point(3).Y)
                    'ExEnd:GetAllPossible1DBarcodesfromImage 
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
