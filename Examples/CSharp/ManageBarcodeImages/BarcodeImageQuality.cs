using System.IO;

using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class BarcodeImageQuality
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();
            
            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567";

            // Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128;

            // Set the image quality mode to anti alias
            barCodeBuilder.ImageQuality = ImageQualityMode.AntiAlias;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-image-quality_out.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
