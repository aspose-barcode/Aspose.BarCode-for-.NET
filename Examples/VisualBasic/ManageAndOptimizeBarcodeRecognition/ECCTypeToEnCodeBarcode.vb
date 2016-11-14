Imports System.IO
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class ECCTypeToEnCodeBarcode
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

            ' Generate barcode (Sample 1) Initialize BarCode builder class object
            ' Set ECC level
            Dim builder1 As New BarCodeBuilder("BASE-41 ONLY ALPHA, DIGITS AND PUNCTUATION", EncodeTypes.DataMatrix) With { _
                .DatamatrixEcc = DataMatrixEccType.Ecc050 _
            }

            builder1.Save(dataDir & Convert.ToString("SampleBarcode1_out.png"))

            ' Generate barcode (Sample 2) Initialize BarCode builder class object
            ' Set ECC level
            Dim builder2 As New BarCodeBuilder("BASE-41 ONLY ALPHA, DIGITS AND PUNCTUATION.", EncodeTypes.DataMatrix) With { _
                .DatamatrixEcc = DataMatrixEccType.Ecc050 _
            }
            builder2.Save(dataDir & Convert.ToString("SampleBarcode2_out.png"))
        End Sub
    End Class
End Namespace