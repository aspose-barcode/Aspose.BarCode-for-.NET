Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes

    Class CodabarChecksumMode

        Public Shared Sub Run()
            'ExStart:ChecksumSupplementData

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            'Generation
            'Instantiate BarCodeBuilder object
            Dim builder As New Aspose.BarCode.BarCodeBuilder()

            'Set the Code text for the barcode
            builder.CodeText = "1234567890"

            'Set the symbology type to Code128
            builder.EncodeType = Aspose.BarCode.Generation.EncodeTypes.Codabar

            'Set the EnableChecksum property to yes
            builder.EnableChecksum = Aspose.BarCode.EnableChecksum.Yes

            'Set the CodabarChecksumMode
            builder.CodabarChecksumMode = Aspose.BarCode.CodabarChecksumMode.Mod10

            'Save the image on the system
            builder.Save("Codabar_Mod10.png")

            'Recognition
            'Initialize reader object
            Using reader As New Aspose.BarCode.BarCodeRecognition.BarCodeReader("Codabar_Mod10.png", Aspose.BarCode.BarCodeRecognition.DecodeType.Codabar)
                'Set ChecksumValidation property of the reader to On
                reader.ChecksumValidation = Aspose.BarCode.BarCodeRecognition.ChecksumValidation.[On]
                While reader.Read()
                    'Get code text
                    Console.WriteLine("{0}:{1}", reader.GetCodeType(), reader.GetCodeText())

                    'Get checksum value
                    Console.WriteLine("Checksum:" + reader.GetCheckSum())
                End While
            End Using


            'ExEnd:ChecksumSupplementData
        End Sub

    End Class

End Namespace