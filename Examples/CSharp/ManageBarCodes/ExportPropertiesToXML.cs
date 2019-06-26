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
            // ExStart:ExportPropertiesToXML                
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Initialize the BarcodeGenerator  class by passing barcode text and barcode symbology as parameters.
            BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.DataMatrix, "abcdefghijklmnopqrstuvwxyzabcdef");
            // Set various different properties/variables of the barcode.
            generator.Parameters.Border.Visible = true;
            generator.Parameters.Barcode.CodeTextParameters.Location = CodeLocation.Above;
            //generator.D2.Columns = 4;
            //generator.D2.Rows = 3;

            // Specify caption Above settings.
            generator.Parameters.CaptionAbove.Text = "Caption ABOVE";
            generator.Parameters.CaptionAbove.Alignment = TextAlignment.Center;
            generator.Parameters.CaptionAbove.Visible = true;
            generator.Parameters.CaptionAbove.TextColor = Color.Green;
                
            // Specify caption Below settings.
            generator.Parameters.CaptionBelow.Text = "Caption BELOW";
            generator.Parameters.CaptionBelow.Alignment = TextAlignment.Center;
            generator.Parameters.CaptionBelow.Visible = true;
            generator.Parameters.CaptionBelow.TextColor = Color.Yellow;

            // Specify text font settings.
            generator.Parameters.Barcode.CodeTextParameters.Font.FamilyName = "Courier New";
            generator.Parameters.Barcode.CodeTextParameters.Font.Size.Point = 24;
            generator.Parameters.Barcode.CodeTextParameters.Font.Style = FontStyle.Bold;

            // Call the export to XML method to export the properties to XML file.
            generator.Save(dataDir + "BarcodeGenerator .DataMatrix_out.xml");
            // ExEnd:ExportPropertiesToXML                
        }
    }
}
