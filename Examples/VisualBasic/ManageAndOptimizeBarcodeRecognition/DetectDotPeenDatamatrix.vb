Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class DetectDotPeenDatamatrix
        Public Shared Sub Run()
            Try
                'ExStart:DetectDotPeenDatamatrix
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

                ' Initialize the BarCodeReader class by passing barcode file name and barcode type as parameters
                Using reader As New BarCodeReader(dataDir & Convert.ToString("testDotPeen.png"), DecodeType.DataMatrix)

                    ' Set the reader recognition mode and Manual Hint property to speed up recognition process.
                    reader.RecognitionMode = RecognitionMode.ManualHints
                    reader.ManualHints = ManualHint.SpecialFormOfCells
                    While reader.Read()
                        Console.WriteLine("GetCode :: " & reader.GetCodeType().ToString() & ": " & reader.GetCodeText().ToString())
                    End While
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
            End Try
            'ExEnd:DetectDotPeenDatamatrix
        End Sub
    End Class
End Namespace
