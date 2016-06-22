Imports System.IO
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class DetectOrientationOfBarCode
        Public Shared Sub Run()
            'ExStart:DetectOrientationOfBarCode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

            ' Instantiate BarCodeReader object
            Dim reader As New BarCodeReader(dataDir & Convert.ToString("rotatedbarcode.jpg"), DecodeType.Code128)

            Try
                ' read Code39 bar code
                While reader.Read()
                    ' detect bar code orientation
                    System.Console.Write(Environment.NewLine + "Rotaion Angle: " + reader.GetAngle())
                End While
                'ExEnd:DetectOrientationOfBarCode
                reader.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try

            Console.WriteLine((Convert.ToString(Environment.NewLine + "Barcode recognized from ") & dataDir) + "rotatedbarcode.jpg")

        End Sub
    End Class
End Namespace
