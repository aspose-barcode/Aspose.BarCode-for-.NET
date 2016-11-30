using System.Drawing.Imaging;
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
    class WideNarrowRatio
    {
        public static void Run()
        {           
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate linear barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567",EncodeTypes.Code39Standard);

            // Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 3.0f;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode_ratio_3_out.jpg", ImageFormat.Jpeg);

            // Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 5.0f;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode_ratio_5_out.jpg", ImageFormat.Jpeg);

            // Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 7.0f;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode_ratio_7_out.jpg", ImageFormat.Jpeg);

            // Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 9.0f;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "code39-wide-narrow-ratio_out.jpg", ImageFormat.Jpeg);

        }
    }
}
