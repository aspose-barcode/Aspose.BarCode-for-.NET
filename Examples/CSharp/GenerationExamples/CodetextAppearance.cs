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
    class CodetextAppearance
    {
        public static void Run()
        {
            // ExStart:CodetextAppearance 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();
            string dst = dataDir + "codetext-appearence_out.jpg";

            // Set the symbology type to Code128
            using (BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128, "1234567"))
            {
                // Set differnt barcode properties
                generator.Parameters.Barcode.CodeTextParameters.Alignment = TextAlignment.Center;
                generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.Above;
                generator.Parameters.Barcode.CodeTextParameters.Color = Color.Red;
                generator.Parameters.Barcode.CodeTextParameters.Space.Millimeters = 1.0f;
                generator.Save(dst, BarCodeImageFormat.Jpeg);
            };
            
            // ExEnd:CodetextAppearance 
        }
    }
}