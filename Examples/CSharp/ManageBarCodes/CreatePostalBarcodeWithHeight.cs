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
    class CreatePostalBarcodeWithHeight
    {
        public static void Run()
        {
            // ExStart:ChecksumSupplementData 

            // Create an instance of BarCodeGenerator class
            // Set barcode text
            // Set encoding type

            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.AustraliaPost, "12345678"))
            {
                // Set barcode Dimension and height
                generator.XDimension.Pixels = 1f;
                generator.BarHeight.Millimeters = 40;

                // Save the barcode image
                generator.Save("postnet.png");
            }

            // ExEnd:ChecksumSupplementData 
        }
    }
}