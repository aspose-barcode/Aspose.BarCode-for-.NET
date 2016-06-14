using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.Programming.BarCode
{
    class WideNarrowRatio
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ProgrammingBarCode();
            string dst = dataDir + "code39-wide-narrow-ratio.png";

            //Instantiate linear barcode object
            BarCodeBuilder bb = new BarCodeBuilder();

            //Set the Code text for the barcode
            bb.CodeText = "1234567";

            //Set the symbology type to Code39
            bb.SymbologyType = Symbology.Code39Standard;

            //Set the wide to narrow ratio for the barcode
            bb.WideNarrowRatio = 3.0f;

            //Save the image to your system
            //and set its image format to Jpeg
            bb.Save(dataDir + "barcode_ratio_3.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            //Set the wide to narrow ratio for the barcode
            bb.WideNarrowRatio = 5.0f;

            //Save the image to your system
            //and set its image format to Jpeg
            bb.Save(dataDir + "barcode_ratio_5.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            //Set the wide to narrow ratio for the barcode
            bb.WideNarrowRatio = 7.0f;

            //Save the image to your system
            //and set its image format to Jpeg
            bb.Save(dataDir + "barcode_ratio_7.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            //Set the wide to narrow ratio for the barcode
            bb.WideNarrowRatio = 9.0f;

            //Save the image to your system
            //and set its image format to Jpeg
            bb.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
