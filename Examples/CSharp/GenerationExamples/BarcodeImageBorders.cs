using Aspose.BarCode.Generation;
using System.Drawing.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.GenerationExamples
{
    class BarcodeImageBorders
    {
        public static void Run()
        {
            // ExStart:BarcodeImageBorders   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();

            // Instantiate barcode object and set different properties
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code93Standard);

            generator.Parameters.Border.DashStyle = BorderDashStyle.Solid;
            generator.Parameters.Border.Width.Millimeters = 0.5f;
            generator.Parameters.Border.Visible = true;

            generator.Parameters.Barcode.Padding.Top.Millimeters = 2f;
            generator.Parameters.Barcode.Padding.Left.Millimeters = 2f;
            generator.Parameters.Barcode.Padding.Right.Millimeters = 2f;
            generator.Parameters.Barcode.Padding.Bottom.Millimeters = 2f;

            generator.Save(dataDir + "barcodeImageborders_out.jpeg", BarCodeImageFormat.Jpeg);
            // ExEnd:BarcodeImageBorders   
        }
    }
}
