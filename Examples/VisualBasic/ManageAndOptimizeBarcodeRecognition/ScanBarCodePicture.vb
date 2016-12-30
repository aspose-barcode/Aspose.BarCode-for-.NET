Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class ScanBarCodePicture
        Public Shared Sub Run()
            'ExStart:ScanBarCodePicture
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()
            Try
                ' Read file from directory with DecodeType.EAN13
                Dim reader As New BarCodeReader(dataDir & Convert.ToString("Scan.jpg"), DecodeType.EAN13)
                While reader.Read()
                    ' Read symbology type and code text
                    Console.WriteLine("Symbology Type: " & reader.GetCodeType().ToString())
                    Console.WriteLine("CodeText: " & reader.GetCodeText().ToString())
                End While
                reader.Close()
                'ExEnd:ScanBarCodePicture
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace