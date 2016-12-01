Imports System.Drawing.Imaging
Imports Aspose.BarCode.BarCodeRecognition

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class ReadBarcodeFromTIFFImages
        Public Shared Sub Run()
            Try
                ' ExStart:ReadBarcodeFromTIFFImages
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()
                Dim img = System.Drawing.Image.FromFile(dataDir & Convert.ToString("tiffImage.tif"))
                Dim totalFrame As Integer = img.GetFrameCount(FrameDimension.Page)

                ' Feed the pages to BarCodeReader one by one
                For i As Integer = 0 To totalFrame - 1
                    ' Set the active page and feed it to the BarCodeReader
                    Dim w = img.SelectActiveFrame(FrameDimension.Page, i)
                    Dim bitmap = New System.Drawing.Bitmap(img)
                    Dim reader As New BarCodeReader(bitmap, DecodeType.AllSupportedTypes)
                    While reader.Read()
                        Console.WriteLine(reader.GetCodeText() & " " & reader.GetCodeType().ToString())
                    End While
                    ' ExEnd:ReadBarcodeFromTIFFImages
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.")
            End Try
        End Sub
    End Class
End Namespace