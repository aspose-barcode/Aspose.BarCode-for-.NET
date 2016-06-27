using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class ManageXYDimension
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();
            string dstCode128 = dataDir + "code128-YDimensionChanged.jpg";

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567";

            // Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dstCode128, System.Drawing.Imaging.ImageFormat.Jpeg);

            // Set the X-Dimension for the bars of the barcode
            barCodeBuilder.xDimension = 0.5f;

            // Set the measuring unit of barcode to millimeter
            barCodeBuilder.GraphicsUnit = System.Drawing.GraphicsUnit.Millimeter;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dstCode128, System.Drawing.Imaging.ImageFormat.Jpeg);

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder1 = new BarCodeBuilder();

            // Set the Code text for the barcode
            barCodeBuilder1.CodeText = "1234567";

            // Set the symbology type to Pdf417
            barCodeBuilder1.SymbologyType = Symbology.Pdf417;

            // Set the Y-Dimension for the bars of the barcode
            barCodeBuilder1.yDimension = 4;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder1.Save(dataDir + "pdf417-YDimensionChanged_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
