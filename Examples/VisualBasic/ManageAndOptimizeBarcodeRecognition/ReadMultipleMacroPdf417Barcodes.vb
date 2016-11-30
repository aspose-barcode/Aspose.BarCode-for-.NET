Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class ReadMultipleMacroPdf417Barcodes
        Public Shared Sub Run()

            Try                
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

                ' Create array for storing multiple bar codes file names
                Dim files As String() = New String() {"Barcodefrom.png", "Barcode2.png"}

                ' Iiterate through the bar code image files
                For i As Integer = 0 To files.Length - 1

                    ' Create instance of BarCodeReader class and set symbology
                    Using reader As New BarCodeReader(dataDir + files(i), DecodeType.MacroPdf417)

                        If reader.Read() Then
                            ' Get code text, file id, segment id, segment id
                            Console.WriteLine("File Name: " + files(i) + " Code Text: " + reader.GetCodeText())
                            Console.WriteLine("FileID: " + reader.GetMacroPdf417FileID())
                            Console.WriteLine("SegmentID: " + reader.GetMacroPdf417SegmentID())
                            Console.WriteLine("Segment Count: " + reader.GetMacroPdf417SegmentsCount())
                        End If
                        Console.WriteLine()
                    End Using
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
