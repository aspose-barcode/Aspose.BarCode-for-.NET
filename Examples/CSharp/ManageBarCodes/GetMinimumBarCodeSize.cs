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
            // ExStart:ChecksumSupplementData 

            // Create an instance of BarCodeBuilder class
            // Set barcode text
            // Set encoding type
            using (Aspose.BarCode.BarCodeBuilder builder = new Aspose.BarCode.BarCodeBuilder("1234567890", Aspose.BarCode.Generation.EncodeTypes.Code128))
            {
                // Set graphic unit
                builder.GraphicsUnit = System.Drawing.GraphicsUnit.Pixel;

                // Call GetMinimumBarCodeSize method to get the minimum size required
                System.Drawing.SizeF minSize = builder.GetMinimumBarCodeSize();

                // Set Auto size to false
                builder.AutoSize = false;

                // Set image height & width with the help of min size got from GetMinimumBarCodeSize method
                builder.ImageWidth = minSize.Width;
                builder.ImageHeight = minSize.Height;

                // Save the barcode image
                using (System.Drawing.Bitmap image = builder.BarCodeImage)
                    image.Save("minimumresult.png");

                // ExEnd:ChecksumSupplementData 
            }
        }
    }
}