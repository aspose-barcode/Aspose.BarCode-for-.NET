using System;
using System.Drawing;
using Aspose.BarCode;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
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
            BarCodeBuilder builder = new BarCodeBuilder("abcdefghijklmnopqrstuvwxyzabcdef", Symbology.DataMatrix);

            // set various different properties/variables of the barcode.
            builder.BorderVisible = true;
            builder.ImageQuality = ImageQualityMode.AntiAlias;
            builder.CodeLocation = CodeLocation.Above;
            builder.Columns = 4;
            builder.Rows = 3;

            // Specify caption settings.
            builder.CaptionAbove = new Caption("{Caption ABOVE}");
            builder.CaptionAbove.TextAlign = System.Drawing.StringAlignment.Center;
            builder.CaptionAbove.Visible = true;
            builder.CaptionAbove.ForeColor = Color.Green;

            builder.CaptionBelow = new Caption("{Caption BELOW}");
            builder.CaptionBelow.TextAlign = System.Drawing.StringAlignment.Far;
            builder.CaptionBelow.Visible = true;
            builder.CaptionBelow.ForeColor = Color.Yellow;

            // Specify text font settings.
            builder.CodeTextFont = new Font("Courier New", 24, FontStyle.Bold | FontStyle.Italic);

            // call the export to XML method to export the properties to XML file.
            builder.ExportToXml(dataDir + "BarCodeBuilder.DataMatrix_out.xml");

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "BarCodeBuilder.DataMatrix.xml");
        }
    }
}
