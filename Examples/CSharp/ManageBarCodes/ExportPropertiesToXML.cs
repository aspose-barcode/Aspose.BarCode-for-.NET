using System.Drawing;
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
    class ExportPropertiesToXML
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Initialize the BarCodeBuilder class by passing barcode text and barcode symbology as parameters.
            BarCodeBuilder builder = new BarCodeBuilder("abcdefghijklmnopqrstuvwxyzabcdef", EncodeTypes.DataMatrix)
            {
                // Set various different properties/variables of the barcode.
                BorderVisible = true,
                ImageQuality = ImageQualityMode.AntiAlias,
                CodeLocation = CodeLocation.Above,
                Columns = 4,
                Rows = 3,
                CaptionAbove = new Caption("{Caption ABOVE}")
                {
                    TextAlign = StringAlignment.Center,
                    Visible = true,
                    ForeColor = Color.Green
                }
            };
           
            // Specify caption settings.
            builder.CaptionBelow = new Caption("{Caption BELOW}");
            builder.CaptionBelow.TextAlign = StringAlignment.Far;
            builder.CaptionBelow.Visible = true;
            builder.CaptionBelow.ForeColor = Color.Yellow;

            // Specify text font settings.
            builder.CodeTextFont = new Font("Courier New", 24, FontStyle.Bold | FontStyle.Italic);

            // Call the export to XML method to export the properties to XML file.
            builder.ExportToXml(dataDir + "BarCodeBuilder.DataMatrix_out.xml");
        }
    }
}
