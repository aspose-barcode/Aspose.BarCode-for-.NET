Imports System.IO
Imports System.Diagnostics
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
    Class RecognizeMultipleSymbologies
        Public Shared Sub Run()
            Try
                'ExStart:RecognizeMultipleSymbologies
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

                ' Initialize the BarCodeReader 
                Dim reader As New BarCodeReader(dataDir & Convert.ToString("RecognizingMultipleSymbologies.png"), DecodeType.AllSupportedTypes)

                ' Call Read() method in a loop
                While reader.Read()
                    ' Display the codetext and symbology type
                    Console.WriteLine("Codetext: " & reader.GetCodeText().ToString())
                    Console.WriteLine("Symbology type: " & reader.GetCodeType().ToString())
                End While
                'ExEnd:RecognizeMultipleSymbologies 
                reader.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
