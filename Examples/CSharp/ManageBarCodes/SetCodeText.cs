using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SetCodeText
    {
        public static void Run()
        {
            //ExStart:SetCodeText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate BarCodeBuilder object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567";

            // Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128;

            // Set the width of the bars to 1 millimeters
            barCodeBuilder.xDimension = 1f;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-codetext_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //ExEnd:SetCodeText
            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "barcode-codetext_out.jpg");
        }
    }
}
