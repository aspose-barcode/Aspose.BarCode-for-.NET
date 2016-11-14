
Imports System.IO
Imports System.Diagnostics
Imports System.Drawing.Imaging
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class RecognizeMultipleSymbologies
        Public Shared Sub Run()
            Try

                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

                Dim objArray As BaseDecodeType() = New BaseDecodeType() {DecodeType.Code39Standard, DecodeType.Pdf417}

                ' Initialize the BarCodeReader 
                Dim reader As New BarCodeReader(dataDir & Convert.ToString("RecognizingMultipleSymbologies.png"), objArray)

                ' Call Read() method in a loop
                While reader.Read()
                    ' Display the codetext and symbology type
                    Console.WriteLine("Codetext: " & reader.GetCodeText())
                    Console.WriteLine("Symbology type: " & DirectCast(reader.GetCodeType(), Object))
                End While
                reader.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
