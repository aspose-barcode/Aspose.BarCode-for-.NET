using System.Drawing.Imaging;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class BarcodeImageMargins
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object and different properties
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567890", EncodeTypes.Code128)
            {
                Margins = {Left = 0.5f, Right = 0f, Top = 0f, Bottom = 0f}
            };
            barCodeBuilder.Save(dataDir + "barcode-image-margins_out.jpeg", ImageFormat.Jpeg);
        }
    }
}
