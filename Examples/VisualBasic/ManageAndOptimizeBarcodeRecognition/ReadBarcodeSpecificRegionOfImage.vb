Imports System.Drawing
Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class ReadBarcodeSpecificRegionOfImage
        Public Shared Sub Run()
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

                ' Create an instance of BarCodeReader class and specify an area to look for the barcode
                Dim reader As New BarCodeReader(New Bitmap(dataDir & Convert.ToString("ReadBarcodefromSpecificRegionofImage.png")), New Rectangle(0, 0, 100, 50), DecodeType.Pdf417)

                ' Read all barcodes in the provided area
                While reader.Read() = True

                    ' Display the codetext and symbology type of the barcode found
                    Console.WriteLine("Codetext: " & reader.GetCodeText().ToString() & " Symbology: " & reader.GetCodeType().ToString())
                End While
                ' Close the reader
                reader.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace
