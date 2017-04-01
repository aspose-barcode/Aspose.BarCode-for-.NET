Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class BarcodeWithChecksumValue

        Public Shared Sub Run()
            'ExStart:ChecksumSupplementData

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            'Initialize reader object
            Using reader As New Aspose.BarCode.BarCodeRecognition.BarCodeReader("error5.jpg", Aspose.BarCode.BarCodeRecognition.DecodeType.EAN13)
                While reader.Read()
                    'Get code text by passing TRUE to get the Barcode along with checksum value
                    Console.WriteLine("{0}: {1}", reader.GetCodeType(), reader.GetCodeText(True))
                End While
            End Using


            'ExEnd:ChecksumSupplementData
        End Sub

    End Class
End Namespace