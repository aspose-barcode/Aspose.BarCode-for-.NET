using System.IO;
using Aspose.BarCode;
using System;
using System.Drawing.Printing;

namespace Aspose.BarCode.Examples.CSharp.BarCode.Image.Basic.Features
{
    class SetSizeUnitForBarcodeImage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_BarCodeImage();
            string dst = dataDir + "barcode-size-unit.jpg";

            //Instantiate barcode object
            BarCodeBuilder bb = new BarCodeBuilder();

            //Set the Code text for the barcode
            bb.CodeText = "1234567";

            //Set the symbology type to Code128
            bb.SymbologyType = Symbology.Code128;

            //Set the bar height to 3 points
            bb.BarHeight = 3.0f;

            //Set the measuring unit of barcode to point
            bb.GraphicsUnit = System.Drawing.GraphicsUnit.Point;

            //Save the image to your system
            //and set its image format to Jpeg
            bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
