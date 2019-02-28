using Aspose.BarCode.Generation;
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
    class BarcodeImageBorders
    {
        public static void Run()
        {
            // ExStart:BarcodeImageBorders   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object and set different properties
            BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.Code93Standard);
            generator.Border.DashStyle = BorderDashStyle.Solid;
            generator.Margins.Top.Millimeters = 2f;
            generator.Margins.Left.Millimeters = 2f;
            generator.Margins.Right.Millimeters = 2f;
            generator.Margins.Bottom.Millimeters = 2f;
            generator.Border.Width.Millimeters = 0.5f;
            generator.Border.Visible = true;

            generator.Save(dataDir + "barcodeImageborders_out.jpeg", BarCodeImageFormat.Jpeg);
            // ExEnd:BarcodeImageBorders   
        }
    }
}
