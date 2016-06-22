using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CodetextAppearance
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();
            string dst = dataDir + "codetext-appearence.jpg";

            //ExStart:CodetextAppearance
            // Instantiate bar code object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Code text for the bar code
            barCodeBuilder.CodeText = "1234567";

            // Align the code text to center
            barCodeBuilder.CodeTextAlignment = System.Drawing.StringAlignment.Center;

            // Set the location of the code text to above the bar code
            barCodeBuilder.CodeLocation = CodeLocation.Above;

            // Set the code text fore color to red
            barCodeBuilder.CodeTextColor = System.Drawing.Color.Red;

            // Increase the space between code text and barcode to 1 point
            barCodeBuilder.CodeTextSpace = 1.0f;

            // Set the symbology type to Code128
            barCodeBuilder.SymbologyType = Symbology.Code128;

            //ExEnd:CodetextAppearance
            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
