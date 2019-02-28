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

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CodetextAppearance
    {
        public static void Run()
        {
            // ExStart:CodetextAppearance 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();
            string dst = dataDir + "codetext-appearence_out.jpg";

            // Set the symbology type to Code128
            using (BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.Code128, "1234567"))
            {
                // Set differnt barcode properties
                generator.CodeTextStyle.Alignment = StringAlignment.Center;
                generator.CodeTextStyle.Location = CodeLocation.Above;
                generator.CodeTextStyle.Color = Color.Red;
                generator.CodeTextStyle.Space.Millimeters = 1.0f;
                generator.Save(dst, BarCodeImageFormat.Jpeg);
            };
            
            // ExEnd:CodetextAppearance 
        }
    }
}