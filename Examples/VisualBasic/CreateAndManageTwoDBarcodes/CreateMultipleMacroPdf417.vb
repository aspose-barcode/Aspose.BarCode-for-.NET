Imports System.Diagnostics
Imports System.Drawing.Imaging
Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class CreateMultipleMacroPdf417
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' Create array for storing multiple barcodes
            Const nSize As Integer = 4
            Dim lstCodeText As String() = New String() {"code-1", "code-2", "code-3", "code-4"}
            Const strFileId As Integer = 1

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            Using builder As New BarCodeBuilder("1234567890", EncodeTypes.MacroPdf417)
                For nCount As Integer = 1 To nSize
                    builder.CodeText = lstCodeText(nCount - 1)

                    ' FileID should be same for all the generated bar codes
                    builder.MacroPdf417FileID = strFileId

                    ' Assign segmentID in increasing order (1,2,3,....)
                    builder.MacroPdf417SegmentID = nCount

                    ' Set the segments count
                    builder.MacroPdf417SegmentsCount = nSize

                    Try
                        ' Save the barcode (fileid_segmentid.png)
                        builder.Save((dataDir & strFileId) + "_" + nCount + "_out.png", ImageFormat.Png)
                        Process.Start((dataDir & strFileId) + "_" + nCount + "_out.png")
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                Next
            End Using
        End Sub
    End Class
End Namespace