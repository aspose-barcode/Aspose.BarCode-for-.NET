using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CreateCouponExtendedBarcode
    {
        public static void Run()
        {
            // ExStart:CreateCouponExtendedBarcode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.UpcaGs1Code128Coupon, "514141100906(8102)03");
            generator.Save(dataDir + "UpcaGs1Code128Coupon_out.png");
            // ExEnd:CreateCouponExtendedBarcode
        }
    }
}

