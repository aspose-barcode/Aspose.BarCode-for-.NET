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
    class BarcodeCaption
    {
        public static void Run()
        {
            // ExStart:BarcodeCaption 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.Code128, "1234567")
            {
                CaptionAbove = {Visible = false}
            };

            // Set caption above its text and text alignment & also make it visible
            generator.CaptionAbove.Visible = true;
            generator.CaptionAbove.Text = "Aspose";
            generator.CaptionAbove.Alignment = StringAlignment.Center;
            generator.CaptionAbove.Color = Color.Red;
            generator.CaptionAbove.Font.FamilyName = "Pristina";
            generator.CaptionAbove.Font.Size.Point = 14;
            //space between the barcode and the caption
            generator.CaptionAbove.Space.Millimeters = 5;

            // Assign caption object to be displayed above the barcode
            generator.CaptionBelow.Visible = true;
            generator.CaptionBelow.Text = "Aspose Caption below";
            generator.CaptionBelow.Alignment = StringAlignment.Center;
            generator.CaptionBelow.Color = Color.OrangeRed;
            generator.CaptionBelow.Font.Size.Point = 14;
            generator.CaptionBelow.Font.FamilyName = "Pristina";
            //space between the barcode and the caption
            generator.CaptionBelow.Space.Millimeters = 5;

            // Save the image to your system and set its image format to Jpeg
            generator.Save(dataDir + "barcode-caption_out.jpg",BarCodeImageFormat.Jpeg);
            //ExEnd:BarcodeCaption
        }
    }
}
