Imports System.IO
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageAndOptimizeBarCodeRecognition
    Class ECCTypeToEnCodeBarcode
        Public Shared Sub Run()
            'ExStart:ECCTypeToEnCodeBarcode               
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageAndOptimizeBarcodeRecognition()

            ' Generate barcode (Sample 1) Initialize BarCode builder class object
            Dim builder1 As New BarCodeBuilder()

            ' Set symbology type as DataMatrix
            builder1.SymbologyType = Symbology.DataMatrix

            ' Set ECC level
            builder1.DatamatrixEcc = DataMatrixEccType.Ecc050

            ' Set code text
            builder1.CodeText = "BASE-41 ONLY ALPHA, DIGITS AND PUNCTUATION."

            ' Save barcode
            builder1.Save(dataDir & Convert.ToString("SampleBarcode1.png"))

            ' Generate barcode (Sample 2) Initialize BarCode builder class object
            Dim builder2 As New BarCodeBuilder()

            ' Set symbology type as DataMatrix
            builder2.SymbologyType = Symbology.DataMatrix

            ' Set ECC level
            builder2.DatamatrixEcc = DataMatrixEccType.Ecc050

            ' Set code text
            builder2.CodeText = "BASE-41 ONLY ALPHA, DIGITS AND PUNCTUATION."

            ' Save barcode
            builder2.Save(dataDir & Convert.ToString("SampleBarcode2.png"))
            'ExEnd:ECCTypeToEnCodeBarcode 
        End Sub
    End Class
End Namespace