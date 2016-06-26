Imports System.IO
Imports System.Diagnostics
Imports System.Drawing.Imaging
Imports System.Text
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class CreateMultipleMacroPdf417
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' create array for storing multiple barcodes
            Const nSize As Integer = 4
            Dim lstCodeText As String() = New String() {"code-1", "code-2", "code-3", "code-4"}
            Const strFileId As Integer = 1

            ' create instance of BarCodeBuilder class and set symbology
            Using builder As New BarCodeBuilder()
                For nCount As Integer = 1 To nSize
                    builder.SymbologyType = Symbology.MacroPdf417
                    builder.CodeText = lstCodeText(nCount - 1)

                    ' fileID should be same for all the generated bar codes
                    builder.MacroPdf417FileID = strFileId
                    ' assign segmentID in increasing order (1,2,3,....)
                    builder.MacroPdf417SegmentID = nCount
                    ' set the segments count
                    builder.MacroPdf417SegmentsCount = nSize

                    ' save the barcode (fileid_segmentid.png)
                    builder.Save(dataDir & strFileId.ToString() + "_" & nCount & "_out.png", ImageFormat.Png)
                    Process.Start(dataDir & strFileId.ToString + "_" & nCount & "_out.png")
                Next
            End Using
        End Sub
    End Class
End Namespace