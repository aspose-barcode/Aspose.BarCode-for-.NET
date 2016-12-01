Imports System.IO
Imports System.Text
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class DetectUnicodeEncoding
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            Try
                Dim memoryStream As New MemoryStream()
                ' Instantiate barcode object, Set CodeText, Barcode Symbology and Text Encoding

                Using barCodeBuilder As New BarCodeBuilder()
                    Dim builder As New BarCodeBuilder("Слово", EncodeTypes.QR)
                    barCodeBuilder.CodeTextEncoding = Encoding.UTF8
                    barCodeBuilder.Save((dataDir & Convert.ToString("")) & DirectCast(memoryStream, Object) & "_out.png", BarCodeImageFormat.Png)
                End Using

                Dim fileName As String = (dataDir & Convert.ToString("")) & DirectCast(memoryStream, Object) & "_out.png"
                Using reader As New BarCodeReader(fileName, DecodeType.QR)
                    reader.SetDetectEncoding(False)
                    If reader.Read() Then
                        Console.WriteLine(reader.GetCodeText(Encoding.UTF8))
                        '"Слово"
                    End If
                End Using
            Catch generatedExceptionName As Exception
            End Try
        End Sub
    End Class
End Namespace