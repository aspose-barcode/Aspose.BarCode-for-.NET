Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class DetectOrientationOfBarCode
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

            ' Instantiate BarCodeReader object
            Dim reader As New BarCodeReader(dataDir & Convert.ToString("rotatedbarcode.jpg"), DecodeType.Code128)

            Try
                ' Read Code39 bar code and Detect bar code orientation
                While reader.Read()
                    System.Console.Write(Environment.NewLine + "Rotaion Angle: " + reader.GetAngle())
                End While
                reader.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
            End Try
            Console.WriteLine((Convert.ToString(Environment.NewLine + "Barcode recognized from ") & dataDir) + "rotatedbarcode.jpg")
        End Sub
    End Class
End Namespace
