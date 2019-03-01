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
    class GetMinimumBarCodeSize
    {
        public static void Run()
        {
            // ExStart:GetMinimumBarCodeSize 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Create an instance of BarCodeGenerator class
            // Set barcode text
            // Set encoding type
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.Code128, "1234567890"))
            {
                // Set Auto size to None
                generator.AutoSizeMode = AutoSizeMode.None;

                // Set image height & width to minimum
                generator.BarCodeWidth.Millimeters = 1;
                generator.BarCodeHeight.Millimeters = 1;

                // Save the barcode image
                generator.Save(dataDir + "barcode-image-minimum_out.jpeg", BarCodeImageFormat.Jpeg);
            }

            // ExEnd:GetMinimumBarCodeSize 
        }
    }
}