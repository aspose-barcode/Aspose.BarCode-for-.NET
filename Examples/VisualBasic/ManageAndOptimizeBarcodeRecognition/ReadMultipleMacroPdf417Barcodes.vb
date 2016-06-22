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
    Class ReadMultipleMacroPdf417Barcodes
        Public Shared Sub Run()

            Try
                'ExStart:ReadMultipleMacroPdf417Barcodes               

                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()
                ' Create array for storing multiple bar codes file names
                Dim files As String() = New String() {"Barcodefrom.png", "Barcode2.png"}

                ' Iiterate through the bar code image files
                For i As Integer = 0 To files.Length - 1
                    ' Create instance of BarCodeReader class and set symbology
                    Using reader As New BarCodeReader(dataDir + files(i), DecodeType.MacroPdf417)

                        If reader.Read() Then
                            ' Get code text
                            Console.WriteLine("File Name: " + files(i) + " Code Text: " + reader.GetCodeText())
                            ' Get file id
                            Console.WriteLine("FileID: " + reader.GetMacroPdf417FileID())
                            ' Get segment id
                            Console.WriteLine("SegmentID: " + reader.GetMacroPdf417SegmentID())
                            ' Get segment count
                            Console.WriteLine("Segment Count: " + reader.GetMacroPdf417SegmentsCount())
                        End If
                        Console.WriteLine()
                    End Using
                    'ExEnd:ReadMultipleMacroPdf417Barcodes 


                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try

        End Sub
    End Class
End Namespace
