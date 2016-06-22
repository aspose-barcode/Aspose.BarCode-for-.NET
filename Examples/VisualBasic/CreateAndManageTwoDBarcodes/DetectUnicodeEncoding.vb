Imports System.IO
Imports System.Text
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class DetectUnicodeEncoding
        Public Shared Sub Run()
            'ExStart:DetectUnicodeEncoding
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            Try
                Dim memoryStream As New MemoryStream()
                ' Instantiate barcode object
                Using barCodeBuilder As New BarCodeBuilder()
                    ' Set CodeText 
                    barCodeBuilder.CodeText = "Слово"

                    ' Set Barcode Symbology
                    barCodeBuilder.SymbologyType = Symbology.QR

                    ' Set Text Encoding
                    barCodeBuilder.CodeTextEncoding = Encoding.UTF8

                    ' Save the Barcode image
                    barCodeBuilder.Save(dataDir & "" & DirectCast(memoryStream, Object) & "_out.png", BarCodeImageFormat.Png)
                End Using

                Dim fileName As String = (dataDir & Convert.ToString("")) + DirectCast(memoryStream, Object) + "_out.png"

                Using reader As New BarCodeReader(fileName, DecodeType.QR)
                    reader.SetDetectEncoding(False)
                    If reader.Read() Then
                        Console.WriteLine(reader.GetCodeText(Encoding.UTF8))
                        '"Слово"
                    End If

                End Using

            Catch generatedExceptionName As Exception
            End Try
            'ExEnd:DetectUnicodeEncoding
        End Sub
    End Class
End Namespace