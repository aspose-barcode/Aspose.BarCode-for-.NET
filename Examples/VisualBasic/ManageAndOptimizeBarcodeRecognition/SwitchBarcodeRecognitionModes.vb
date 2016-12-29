Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class SwitchBarcodeRecognitionModes
        Public Shared Sub Run()
            Try
                'ExStart:SwitchBarcodeRecognitionModes
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

                ' Initialize the BarCodeReader object
                Dim reader As New BarCodeReader(dataDir & Convert.ToString("datamatrix-barcode.jpg"), DecodeType.DataMatrix)

                ' Set recognition mode,  manual hints
                reader.RecognitionMode = RecognitionMode.ManualHints
                reader.ManualHints = ManualHint.InvertImage Or ManualHint.IncorrectBarcodes

                ' Try to recognize all possible barcodes in the image and Display the codetext
                While reader.Read()
                    Console.WriteLine("Codetext: " + reader.GetCodeText())
                End While
                ' Close the reader
                reader.Close()
                'ExEnd:SwitchBarcodeRecognitionModes
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace