Imports System.IO
Imports Aspose.BarCode
Imports System.Drawing.Printing
Imports Aspose.BarCodeRecognition

Namespace Aspose.BarCode.Examples.VisualBasic.BarCode.Recognition

    Public Class DetectOrientationOfBarCode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_BarCodeRecognition()
            Dim dst As String = dataDir & Convert.ToString("Code39.png")

            ' Instantiate BarCodeReader object
            Dim reader As New BarCodeReader(dst, BarCodeReadType.Code39Standard)

            Try
                ' read Code39 bar code
                While reader.Read()
                    ' detect bar code orientation
                    System.Console.Write(Environment.NewLine + "Rotaion Angle: " + reader.GetAngle().ToString())
                End While
                reader.Close()

            Catch exp As Exception

                System.Console.Write(exp.Message)
            End Try

            Console.WriteLine(Environment.NewLine + "Barcode recognized from " & dst)
        End Sub
    End Class
End Namespace