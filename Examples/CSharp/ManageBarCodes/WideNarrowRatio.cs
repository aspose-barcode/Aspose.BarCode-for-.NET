using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class WideNarrowRatio
    {
        public static void Run()
        {           
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate linear barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567",EncodeTypes.Code39Standard);

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

        }
    }
}
