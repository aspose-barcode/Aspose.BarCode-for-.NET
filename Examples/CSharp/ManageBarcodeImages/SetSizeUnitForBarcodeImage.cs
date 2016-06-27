using System.IO;
using Aspose.BarCode;
using System;
using System.Drawing.Printing;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class SetSizeUnitForBarcodeImage
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

            // Set the bar height to 3 points
            barCodeBuilder.BarHeight = 3.0f;

            // Set the measuring unit of barcode to point
            barCodeBuilder.GraphicsUnit = System.Drawing.GraphicsUnit.Point;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-size-unit_out.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
