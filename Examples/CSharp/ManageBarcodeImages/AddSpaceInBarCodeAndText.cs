using System.Drawing.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class AddSpaceInBarCodeAndText
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object and set Increase the space between code text and barcode to 1 point
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder {CodeTextSpace = 1.0f};
            barCodeBuilder.Save(dataDir + "AddSpaceInBarCodeAndText_out.bmp", ImageFormat.Bmp);
        }
    }
}