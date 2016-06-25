using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SpecifySymbology
    {
        public static void Run()
        {
            //ExStart:SpecifySymbology
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate BarCodeBuilder object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567";

            // Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-symbiology_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            // ExEnd:SpecifySymbology
        }
    }
}
