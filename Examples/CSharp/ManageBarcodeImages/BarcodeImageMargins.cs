using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class BarcodeImageMargins
    {
        public static void Run()
        {
            //ExStart:BarcodeImageMargins
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();
            
            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567";

            // Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128;

            // sets the left margin
            barCodeBuilder.Margins.Left = 0.5f;

            // sets the right margin
            barCodeBuilder.Margins.Right = 0f;

            // sets the top margin
            barCodeBuilder.Margins.Top = 0f;

            // sets the bottom margin
            barCodeBuilder.Margins.Bottom = 0f;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-image-margins_out.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //ExEnd:BarcodeImageMargins
        }
    }
}
