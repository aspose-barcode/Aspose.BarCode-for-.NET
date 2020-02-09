using System.Drawing;
using System.Drawing.Imaging;
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
    class ManageXDimension
    {
        public static void Run()
        {
            // ExStart:ManageXDimension                
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();
            string dstCode128 = dataDir + "code128-XDimensionChanged_out.jpg";

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarcodeGenerator  generator = new BarcodeGenerator(EncodeTypes.Code128, "1234567");

            // Set the X-Dimension for the bars of the barcode
            generator.Parameters.Barcode.XDimension.Millimeters = 0.9f;

            // Save the image to your system and set its image format to Jpeg
            generator.Save(dstCode128, BarCodeImageFormat.Jpeg);

            // ExEnd:ManageXDimension
        }
    }
}
