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
    class GetMinimumBarCodeSize
    {
        public static void Run()
        {
            // ExStart:ChecksumSupplementData 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();

            // Create an instance of BarcodeGenerator class
            // Set barcode text
            // Set encoding type
            using (BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128, "1234567890"))
            {
                // Set Auto size to None
                generator.Parameters.Barcode.AutoSizeMode = AutoSizeMode.None;

                // Set image height & width to minimum
                generator.Parameters.Barcode.BarCodeWidth.Millimeters = 1;
                generator.Parameters.Barcode.BarCodeHeight.Millimeters = 1;

                // Save the barcode image
                generator.Save(dataDir + "barcode-image-minimum_out.jpeg", BarCodeImageFormat.Jpeg);
                // ExEnd:ChecksumSupplementData 
            }
        }
    }
}