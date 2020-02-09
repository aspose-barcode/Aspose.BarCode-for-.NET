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
    class BarcodeImageMargins
    {
        public static void Run()
        {
            // ExStart:BarcodeImageMargins   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();

            // Instantiate barcode object and different properties
            using (BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128))
            {
                generator.CodeText = "1234567890";
                generator.Parameters.Barcode.Padding.Left.Millimeters = 0.5f;
                generator.Parameters.Barcode.Padding.Right.Millimeters = 0f;
                generator.Parameters.Barcode.Padding.Top.Millimeters = 0f;
                generator.Parameters.Barcode.Padding.Bottom.Millimeters = 0f;
                generator.Save(dataDir + "barcode-image-margins_out.jpeg", BarCodeImageFormat.Jpeg);
            };
            // ExEnd:BarcodeImageMargins   
        }
    }
}
