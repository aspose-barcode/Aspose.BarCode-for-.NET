Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CreateCouponExtendedBarcode
        Public Shared Sub Run()
            ' ExStart:CreateCouponExtendedBarcode
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Initialize BarCode builder class object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set symbology type as GS1-128 AI 8102 coupon extended and set the barcode text
            barCodeBuilder.SymbologyType = Symbology.UpcaGs1Code128Coupon

            ' Upca part is "514141100906", GS1Code128 part is "(8102)03 and save Barcode"
            barCodeBuilder.CodeText = "514141100906(8102)03"
            barCodeBuilder.Save(dataDir & Convert.ToString("UpcaGs1Code128Coupon_out.png"))
            ' ExEnd:CreateCouponExtendedBarcode
        End Sub
    End Class
End Namespace
