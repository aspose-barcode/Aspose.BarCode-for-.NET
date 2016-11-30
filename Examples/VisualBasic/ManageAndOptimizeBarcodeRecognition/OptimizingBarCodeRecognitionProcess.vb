Imports System.Diagnostics
Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class OptimizingBarCodeRecognitionProcess
        Public Shared Sub Run()
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()
                Dim sw As New Stopwatch()

                ' Start the stopwatch
                sw.Start()

                ' Define the settings to use all of the processor cores, if not then how many to use.
                BarCodeReader.ProcessorSettings.UseAllCores = False
                BarCodeReader.ProcessorSettings.UseOnlyThisCoresCount = 4

                ' Perform the BarCode recognition task Initialize the BarCodeReader object
                Using reader As New BarCodeReader(dataDir & Convert.ToString("code39.png"), DecodeType.Code128)
                    While reader.Read()
                        Console.WriteLine("Code Text: " & reader.GetCodeText().ToString() & " Type: " & reader.GetCodeType().ToString())
                    End While
                End Using

                ' Stop the stopwatch
                sw.[Stop]()

                ' Write the Elapsed time to console
                Console.WriteLine("Elapsed: " & sw.Elapsed.ToString())
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace