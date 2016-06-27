Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class SetSupplementData
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set the Code text for the barcode
            barCodeBuilder.CodeText = "123456789123"

            ' Set the symbology type to EAN13
            barCodeBuilder.SymbologyType = Symbology.EAN13

            ' Set the supplement data (5 Digit)
            barCodeBuilder.SupplementData = "12345"

            ' Set space between the supplemental barcode and main barcode
            barCodeBuilder.SupplementSpace = 2.0F

            ' Save the image to your system  
            barCodeBuilder.Save(dataDir & Convert.ToString("SetSupplementData_out.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)

            Console.WriteLine((Convert.ToString(Environment.NewLine + "Barcode saved at ") & dataDir) + "SetSupplementData_out.jpg")
        End Sub
    End Class
End Namespace