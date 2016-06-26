using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SetHeightBarcodeBars
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567";

            // Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128;

            // Set the bar height to 3 millimeters
            barCodeBuilder.BarHeight = 3.0f;

            // Set the measuring unit of barcode to millimeter
            barCodeBuilder.GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter;

            // Save the image locally and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode3_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            // Set the bar height to 3 millimeters
            barCodeBuilder.BarHeight = 7.0f;

            // Save the image locally and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode7_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            // Set the bar height to 3 millimeters
            barCodeBuilder.BarHeight = 11.0f;

            // Save the image to disk
            barCodeBuilder.Save(dataDir + "Code128-bar-height_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
