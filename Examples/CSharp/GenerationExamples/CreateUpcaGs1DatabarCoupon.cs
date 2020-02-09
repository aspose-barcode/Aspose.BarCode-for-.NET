using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.GenerationExamples
{
    class CreateUpcaGs1DatabarCoupon
    {
        public static void Run()
        {
            // ExStart:CreateUpcaGs1DatabarCoupon
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.UpcaGs1DatabarCoupon,
                "512345678900(8110)001234502239811110555");

            generator.Parameters.CaptionAbove.Text = "012345-022398";
            generator.Parameters.CaptionAbove.Visible = true;

            generator.Save(dataDir + "couponUpcaDatabar_out.png");
            // ExEnd:CreateUpcaGs1DatabarCoupon
        }
    }
}