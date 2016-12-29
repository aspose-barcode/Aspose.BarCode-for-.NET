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
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567", EncodeTypes.Code128)
            {
                CaptionAbove = {Visible = false}
            };

            // Create caption object. Set its text and text alignment & also make it visible
            Caption caption = new Caption
            {
                Text = "Aspose",
                TextAlign = StringAlignment.Center,
                Visible = true,
                Font = new Font("Pristina", 14f),
                ForeColor = Color.Red
            };

            // Assign caption object to be displayed above the barcode
            barCodeBuilder.CaptionAbove = caption;
            Caption captionBelow = new Caption
            {
                Text = "Aspose.BarCode Caption Below",
                TextAlign = StringAlignment.Center,
                Visible = true,
                Font = new Font("Pristina", 14f),
                ForeColor = Color.OrangeRed
            };

            // Assign caption object to be displayed below the barcode
            barCodeBuilder.CaptionBelow = captionBelow;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-caption_out.jpg", ImageFormat.Jpeg);
            //ExEnd:BarcodeCaption
        }
    }
}
