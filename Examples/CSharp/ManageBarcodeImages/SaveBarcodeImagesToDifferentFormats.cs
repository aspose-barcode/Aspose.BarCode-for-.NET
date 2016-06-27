using System.IO;
using Aspose.BarCode;
using System;
using System.Drawing.Printing;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class SaveBarcodeImagesToDifferentFormats
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

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-image-format.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
