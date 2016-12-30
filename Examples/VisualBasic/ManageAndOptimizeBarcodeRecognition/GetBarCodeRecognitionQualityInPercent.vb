Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class GetBarCodeRecognitionQualityInPercent
        Public Shared Sub Run()
            Try
                'ExStart:GetBarCodeRegionInformationfromImage
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

                ' Initialize the BarCodeReader object and Call read method
                Dim reader As New BarCodeReader(dataDir & Convert.ToString("Barcode2.png"), DecodeType.AllSupportedTypes)
                While reader.Read()
                    Console.WriteLine("GetCodeText : " & reader.GetCodeText().ToString() + " Type: " + reader.GetCodeType().ToString())
                    Dim percent As Single = reader.GetRecognitionQuality()
                End While
                reader.Close()
                'ExEnd:GetBarCodeRegionInformationfromImage
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace