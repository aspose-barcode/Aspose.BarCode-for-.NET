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
    Class ReadMultipleMacropdf417BarcodeImages
        Public Shared Sub Run()
            Try
                'ExStart:MarkingBarCodeRegionsInImage 
                ' The path to the documents directory.             
                Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()
                Dim strFileID As String = "1"
                Dim strFileslist As String() = Directory.GetFiles((dataDir & strFileID) + "_*.png")
                For Each strFile As String In strFileslist
                    ' we got list of all the files, now read barcodes
                    Dim reader As New BarCodeReader(strFile, DecodeType.MacroPdf417)
                    If reader.Read() = True Then
                        Console.WriteLine((Convert.ToString("File: ") & strFile) + " == FileID: " + reader.GetMacroPdf417FileID() + " == SegmentID: " + reader.GetMacroPdf417SegmentID() + "  == CodeText: " + reader.GetCodeText())
                    End If
                    ' close the reader
                    reader.Close()
                    'ExEnd:MarkingBarCodeRegionsInImage 
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
