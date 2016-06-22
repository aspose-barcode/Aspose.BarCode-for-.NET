using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class WideNarrowRatio
    {
        public static void Run()
        {
           
            //ExStart:WideNarrowRatio
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate linear barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the Code text for the barcode
            barCodeBuilder.CodeText = "1234567";

            // Set the symbology type to Code39
            barCodeBuilder.SymbologyType = Symbology.Code39Standard;

            // Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 3.0f;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode_ratio_3_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            // Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 5.0f;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode_ratio_5_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            // Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 7.0f;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode_ratio_7_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            // Set the wide to narrow ratio for the barcode
            barCodeBuilder.WideNarrowRatio = 9.0f;

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "code39-wide-narrow-ratio_out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //ExEnd:WideNarrowRatio

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "code39-wide-narrow-ratio_out.png");
        }
    }
}
