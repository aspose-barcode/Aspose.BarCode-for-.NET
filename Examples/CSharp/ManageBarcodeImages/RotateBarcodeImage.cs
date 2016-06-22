using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class RotateBarcodeImage
    {
        public static void Run()
        {
            //ExStart:RotateBarcodeImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567";

            // Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128;

            // Set the rotation angle of the barcode to 180 degree
            barCodeBuilder.RotationAngleF = 180;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-image-rotate_out.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //ExEnd:RotateBarcodeImage
        }
    }
}
