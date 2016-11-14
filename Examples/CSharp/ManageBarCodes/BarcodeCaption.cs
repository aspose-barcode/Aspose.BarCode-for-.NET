using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class BarcodeCaption
    {
        public static void Run()
        {
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
                TextAlign = System.Drawing.StringAlignment.Center,
                Visible = true,
                Font = new System.Drawing.Font("Pristina", 14f),
                ForeColor = System.Drawing.Color.Red
            };

            // Assign caption object to be displayed above the barcode
            barCodeBuilder.CaptionAbove = caption;

            Caption captionBelow = new Caption
            {
                Text = "Aspose.BarCode Caption Below",
                TextAlign = System.Drawing.StringAlignment.Center,
                Visible = true,
                Font = new System.Drawing.Font("Pristina", 14f),
                ForeColor = System.Drawing.Color.OrangeRed
            };

            // Assign caption object to be displayed below the barcode
            barCodeBuilder.CaptionBelow = captionBelow;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-caption_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }
    }
}
