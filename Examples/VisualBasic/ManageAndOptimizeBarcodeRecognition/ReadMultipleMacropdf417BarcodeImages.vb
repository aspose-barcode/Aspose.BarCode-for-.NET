Imports System.IO
Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class ReadMultipleMacropdf417BarcodeImages
        Public Shared Sub Run()
            Try
                ' The path to the documents directory.             
                Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()
                Dim strFileID As String = "1"
                Dim strFileslist As String() = Directory.GetFiles((dataDir & strFileID) + "_*.png")
                For Each strFile As String In strFileslist
                    ' We got list of all the files, now read barcodes
                    Dim reader As New BarCodeReader(strFile, DecodeType.MacroPdf417)
                    If reader.Read() = True Then
                        Console.WriteLine((Convert.ToString("File: ") & strFile) + " == FileID: " + reader.GetMacroPdf417FileID() + " == SegmentID: " + reader.GetMacroPdf417SegmentID() + "  == CodeText: " + reader.GetCodeText())
                    End If
                    ' Close the reader
                    reader.Close()
                    ' MarkingBarCodeRegionsInImage 
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
