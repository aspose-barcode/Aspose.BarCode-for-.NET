Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check http://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CreateUpcaGs1DatabarCoupon
        Public Shared Sub Run()
            ' ExStart:CreateUpcaGs1DatabarCoupon
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            Dim barCodeBuilder As New BarCodeBuilder("512345678900(8110)001234502239811110555", EncodeTypes.UpcaGs1DatabarCoupon)

            ' Set barcode caption and barcode
            barCodeBuilder.CaptionAbove.Text = "012345-022398"
            barCodeBuilder.Save(dataDir & Convert.ToString("couponUpcaDatabar.png"))
            ' ExEnd:CreateUpcaGs1DatabarCoupon
        End Sub
    End Class
End Namespace