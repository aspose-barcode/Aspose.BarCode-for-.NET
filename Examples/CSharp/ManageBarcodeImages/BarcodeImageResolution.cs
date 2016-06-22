using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class BarcodeImageResolution
    {
        public static void Run()
        {
            //ExStart:BarcodeImageResolution
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567";

            // Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128;

            // Create an instance of resolution and apply on the barcode image with customized resolution settings
            barCodeBuilder.Resolution = new Resolution(200f, 400f, ResolutionMode.Customized);

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-image-resolution_out.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //ExEnd:BarcodeImageResolution
        }
    }
}
