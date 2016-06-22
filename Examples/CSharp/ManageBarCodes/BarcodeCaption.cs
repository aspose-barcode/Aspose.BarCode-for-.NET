using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class BarcodeCaption
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            //Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567";

            // Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128;

            barCodeBuilder.CaptionAbove.Visible = false;

            // Create caption object. Set its text and text alignment & also make it visible
            Caption caption = new Caption();
            caption.Text = "Aspose";
            caption.TextAlign = System.Drawing.StringAlignment.Center;
            caption.Visible = true;
            caption.Font = new System.Drawing.Font("Pristina", 14f);
            caption.ForeColor = System.Drawing.Color.Red;

            // Assign caption object to be displayed above the barcode
            barCodeBuilder.CaptionAbove = caption;

            Caption captionBelow = new Caption();
            captionBelow.Text = "Aspose.BarCode Caption Below";
            captionBelow.TextAlign = System.Drawing.StringAlignment.Center;
            captionBelow.Visible = true;
            captionBelow.Font = new System.Drawing.Font("Pristina", 14f);
            captionBelow.ForeColor = System.Drawing.Color.OrangeRed;

            // Assign caption object to be displayed below the barcode
            barCodeBuilder.CaptionBelow = captionBelow;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-caption_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }
    }
}
